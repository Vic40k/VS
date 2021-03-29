//import { ChangeDetectionStrategy } from '@angular/compiler/src/core';
import { ChangeDetectorRef } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { DataService } from '../data.service';

@Component({
  selector: 'app-info-screens',
  templateUrl: './infoScreensWarehouse.component.html',
  styleUrls: ['./infoScreensWarehouse.component.css'],
  providers: [DataService],
  //changeDetection: ChangeDetectionStrategy.OnPush,
})
export class infoScreensWarehouseComponent implements OnInit {
  id: number; // Screen id
  resultQty: number; // Max results on screen
  dataStorage: any[];
  dataShow: any[];
  private routeSubscription: Subscription;
  private querySubscription: Subscription;
  //tableMode: boolean = true; 
  updatePeriod: number = 60; // seconds
  timeLeft: number = this.updatePeriod;
  interval: NodeJS.Timeout;

  isScrol = true;
  scrolInterval = 5; // seconds, must be less than 60 
  maxResultsPerPage: number = 20;
  pageCount: number = 1;
  pageCounter: number = 1;

  isTableVisible = true;

  updateTime: Date = new Date();

  constructor(private ref: ChangeDetectorRef, private dataService: DataService, private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    // Define params from URL
    this.routeSubscription = this.activateRoute.params.subscribe(params => this.id = params['id']);
    this.querySubscription = this.activateRoute.queryParams.subscribe(
      (queryParam: any) => {
          this.resultQty = queryParam['resultQty'];
      }
    );

    this.definePreferences();
    this.loadinfoScreensWarehouse();    // загрузка данных при старте компонента  
    this.startTimer();
  }

  // Some actions before loading data
  definePreferences() {
    // 
  }

  // получаем данные через сервис
  loadinfoScreensWarehouse() {
    this.dataService.getWarehouseInfo()
      .subscribe((data: []) => 
      { 
        this.dataStorage = data; 
        // Count pages if needed
        if (this.isScrol) {
          this.pageCount = Math.round(this.dataStorage.length / this.maxResultsPerPage);
          if (this.dataStorage.length % this.maxResultsPerPage != 0)
            this.pageCount++;
        }
        console.log(this.pageCount);
        console.log(this.dataStorage);
        // Fill array to show in first time
        if (!this.isScrol)
          this.dataShow = Object.assign([], this.dataStorage);
        else 
          this.goToPage(1);
        // Update view
        this.ref.detectChanges(); 
      });
  }

  // - Go to page
  goToPage(pageCounter: number){
    let self = this;
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
              this.pageCounter ++;
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
