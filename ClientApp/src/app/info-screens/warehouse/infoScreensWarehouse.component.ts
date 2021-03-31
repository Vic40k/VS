//import { ChangeDetectionStrategy } from '@angular/compiler/src/core';
import { ChangeDetectorRef } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { UserIntarfaceService } from 'src/app/services/userInterface.service';
import { DataService } from '../../data.service';

@Component({
  selector: 'app-info-screens',
  templateUrl: './infoScreensWarehouse.component.html',
  styleUrls: ['./infoScreensWarehouse.component.css'],
  providers: [DataService],
  //changeDetection: ChangeDetectionStrategy.OnPush,
})
export class InfoScreensWarehouseComponent implements OnInit {
  constructor(
    private ref: ChangeDetectorRef, 
    private dataService: DataService, 
    private activateRoute: ActivatedRoute,
    private _ui: UserIntarfaceService
  ) { }

  dataStorage: any[];
  dataShow: any[];
  private routeSubscription: Subscription;
  private querySubscription: Subscription;
  isLoadComplete: boolean = false;
  updatePeriod: number = 60; // seconds
  timeLeft: number = this.updatePeriod;
  interval: NodeJS.Timeout;

  id: number; // Screen id
  resultQty: number; // Max results on screen
  isUIoff: boolean = false;

  isScrol = true;
  scrolInterval = 5; // seconds, must be less than 60 
  maxResultsPerPage: number = 20;
  pageCount: number = 1;
  pageCounter: number = 1;

  // TODO from - to ?
  pageToShow: number = 0; // 0 or nothing - All

  isTableVisible = true;
  updateTime: Date = new Date();

  ngOnInit() {
    // Disable navbar
    this._ui.setNavbarVisible(false); 
    // Show loading anim while waiting query
    this._ui.setProgressBarNormalLoading();

    // Handle preferences and load after
    this.definePreferences();

    // Main routine
    this.loadinfoScreensWarehouse();
  }

  // Some actions before loading data
  async definePreferences() {
    // Define params from URL
    let promise = new Promise(() => {
      this.routeSubscription = this.activateRoute.params.subscribe(params => this.id = params['id']);
      this.querySubscription = this.activateRoute.queryParams.subscribe(
        (queryParam: any) => {
            this.resultQty = queryParam['resultQty'];
            let isScrollparam:string = queryParam['autoScroll']; 
            if (isScrollparam && typeof isScrollparam === 'string'){
              this.isScrol = isScrollparam.toLowerCase() === 'true';
              if (isScrollparam.toLowerCase() === 'false')
                this.isScrol = false;
            }
            let pageToShowParam:number = +queryParam['pageToShow']; 
            if (pageToShowParam && typeof pageToShowParam === 'number' && pageToShowParam > 0)
              this.pageToShow = Math.ceil(pageToShowParam);
        }
      );
    });
    return await promise;
  }

  // получаем данные через сервис
  loadinfoScreensWarehouse() {
    this.dataService.getWarehouseInfo()
      .subscribe((data: []) => 
      { 
        this.dataStorage = data; 
        // Count pages 
        this.pageCount = Math.trunc(this.dataStorage.length / this.maxResultsPerPage);
        if (this.dataStorage.length % this.maxResultsPerPage != 0)
          this.pageCount++;
        // AutoScrolling
        if (this.isScrol) {
          // ignore pageToShow param and go to first page
          this.goToPage(1);
        } else {
          // Fill array to show in first time
          this.dataShow = Object.assign([], this.dataStorage);
          if (this.pageToShow !== 0 && this.pageToShow <= this.pageCount)
            this.goToPage(this.pageToShow);
          /*
          else
            this.goToPage(1);
          */
        }
        // On first load complete
        if (!this.isLoadComplete){
          // Disable loading anim
          this._ui.stopProgressBarLoading();
          // Go timer! 
          if (this.isScrol)
            this.startTimer();
          this.isLoadComplete = true;
        }
        // Toggle update window
        this.ref.detectChanges(); 

        console.log(this.pageCount + ' pages in total');
        console.log(this.dataStorage);
      });
  }

  // - Go to page
  goToPage(pageCounter: number){
    let self = this;
    // Progressbar
    this._ui.setProgressbarValue(pageCounter / this.pageCount * 100);
    // Set page results
    this.dataShow = this.dataStorage.filter(function (item, index) {
      if (index >= (self.maxResultsPerPage * (pageCounter - 1)) && index < (self.maxResultsPerPage * pageCounter) ) {
        return item;
      }
    });
    console.log(this.dataShow);
  }

  // - Update info by timer
  startTimer() {
    this.interval = setInterval(() => {
      if(this.timeLeft > 0) {
        this.timeLeft--;
        if (this.isScrol) {
          // Time to scrol to next page
          if (this.timeLeft % this.scrolInterval === 0) {
            if (this.pageCounter < this.pageCount)
              this.pageCounter++;
            else
              this.pageCounter = 1;
            console.log('scrol to page #' + this.pageCounter);
            this.goToPage(this.pageCounter);
          }
        }
      } else {
        this.timeLeft = this.updatePeriod;
        this.loadinfoScreensWarehouse();
        this.updateTime = new Date();
        console.log(this.updateTime);
      }
    },1000)
  }

  pauseTimer() {
    clearInterval(this.interval);
  }

  /*
  // сохранение данных
  save() {
    if (this.factoryComponent.articul == null) {
      this.dataService.createFactoryComponent(this.factoryComponent)
        .subscribe((data: FactoryComponent) => this.infoScreensWarehouse.push(data));
    } else {
      this.dataService.updateFactoryComponent(this.factoryComponent)
        .subscribe(data => this.loadinfoScreensWarehouse());
    }
    this.cancel();
  }
  editFactoryComponent(p: FactoryComponent) {
    this.factoryComponent = p;
  }
  cancel() {
    this.factoryComponent = new FactoryComponent();
    this.tableMode = true;
  }
  delete(p: FactoryComponent) {
    this.dataService.deleteFactoryComponent(p.articul)
      .subscribe(data => this.loadinfoScreensWarehouse());
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
  */
}
