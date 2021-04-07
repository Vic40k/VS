import { ChangeDetectorRef, ViewChild } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { faDesktop } from '@fortawesome/free-solid-svg-icons';
import { faWindowMaximize } from '@fortawesome/free-solid-svg-icons';
import { faWindowMinimize } from '@fortawesome/free-solid-svg-icons';
import { UserIntarfaceService } from 'src/app/services/userInterface.service';
import * as signalR from '@microsoft/signalr'; 
import { SignalRService } from 'src/app/services/broadcastService';
import { HttpClient } from '@angular/common/http';
import { DataWarehouseService } from 'src/app/services/dataWarehouse.service';

@Component({
  selector: 'app-info-screens',
  templateUrl: './infoScreensWarehouse.component.html',
  styleUrls: ['./infoScreensWarehouse.component.css'],
  providers: [DataWarehouseService],
})
export class InfoScreensWarehouseComponent implements OnInit {
  constructor(
    private ref: ChangeDetectorRef, 
    private dataService: DataWarehouseService, 
    private activateRoute: ActivatedRoute,
    private router: Router,
    private _ui: UserIntarfaceService,
    public signalRService: SignalRService, 
    private http: HttpClient
  ) { }
  faDesktop = faDesktop;
  faWindowMaximize = faWindowMaximize;
  faWindowMinimize = faWindowMinimize;

  dataStorage: any[];
  dataShow: any[];
  private routeSubscription: Subscription;
  private querySubscription: Subscription;
  isLoadComplete: boolean = false;
  updatePeriod: number = 1; // minutes
  timeLeft: number = this.updatePeriod * 60; // seconds
  interval: NodeJS.Timeout;

  id: number; // Screen id

  isScrol = true;
  scrolInterval = 5; // seconds, must be less than 60 
  maxResultsPerPage: number = 15;
  pageCount: number = 1;
  pageCounter: number = 1;
  pageToShowFrom: number = 1;
  pageToShowTo: number = 0;  // 0 or nothing - All

  isTableVisible = true;
  updateTime: Date = new Date();

  @ViewChild('fullScreen') divRef;

  ngOnInit(): void {
    this.divRef = document.documentElement; 
    // Disable navbar
    this._ui.setNavbarVisible(false); 
    // Show loading anim while waiting query
    this._ui.setProgressBarNormalLoading();

    // Broadcast listening
    //this.brodcastListening();

    // Handle preferences and load after
    this.definePreferences();

    // Main routine
    this.loadinfoScreensWarehouse();
  }

  // Brodcast listening
  brodcastListening() {
    this.signalRService.startConnection();
    this.signalRService.addTransferChartDataListener();
    this.startHttpRequest();
  }
  private startHttpRequest = () => {
    this.http.get('https://localhost:44328/api/info-screens/ForceUpdateAllWarehouseScreens')
      .subscribe(res => {
        console.log(res);
      })
  }

  // Some actions before loading data
  async definePreferences() {
    // Define params from URL
    let promise = new Promise(() => {
      this.routeSubscription = this.activateRoute.params.subscribe(params => this.id = params['id']);
      this.querySubscription = this.activateRoute.queryParams.subscribe(
        (queryParam: any) => {
            let isScrollparam:string = queryParam['autoScroll']; 
            if (isScrollparam && typeof isScrollparam === 'string'){
              this.isScrol = isScrollparam.toLowerCase() === 'true';
              if (isScrollparam.toLowerCase() === 'false')
                this.isScrol = false;
            }
            let scrolIntervalParam:number = +queryParam['scrolInterval']; 
            if (scrolIntervalParam && typeof scrolIntervalParam === 'number' && scrolIntervalParam > 1 && scrolIntervalParam < 60)
              this.scrolInterval = Math.trunc(scrolIntervalParam);              
            let updatePeriodParam:number = +queryParam['updatePeriod']; 
            if (updatePeriodParam && typeof updatePeriodParam === 'number' && updatePeriodParam >= 1 && updatePeriodParam < 720) // from minute to 12 hours
              this.updatePeriod = Math.trunc(updatePeriodParam);              
            let pageToShowFromParam:number = +queryParam['pageToShowFrom']; 
            if (pageToShowFromParam && typeof pageToShowFromParam === 'number' && pageToShowFromParam > 0)
              this.pageToShowFrom = Math.ceil(pageToShowFromParam);
            let pageToShowToParam:number = +queryParam['pageToShowTo']; 
            if (pageToShowToParam && typeof pageToShowToParam === 'number' && pageToShowToParam > 0)
              this.pageToShowTo = Math.ceil(pageToShowToParam);
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
        this._ui.stopProgressBarLoading();
        // Count pages 
        this.pageCount = Math.trunc(this.dataStorage.length / this.maxResultsPerPage);
        if (this.dataStorage.length % this.maxResultsPerPage != 0)
          this.pageCount++;
        // AutoScrolling
        if (!this.isScrol) {
          // Fill array to show in first time
          this.dataShow = Object.assign([], this.dataStorage);
        }
        // Show firt page
        if (this.pageToShowFrom != 0 && this.pageToShowFrom <= this.pageCount)
          this.goToPage(this.pageToShowFrom);
        else
          this.goToPage(1);
        // On first load complete
        if (!this.isLoadComplete){
          // Go timer! 
          if (this.isScrol)
            this.startTimer();
          this.isLoadComplete = true;
        }
        // Toggle update window
        this.ref.detectChanges(); 

        //console.log(this.pageCount + ' pages in total');
        //console.log(this.dataStorage);
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
    //console.log(this.dataShow);
  }

  // - Update info by timer
  startTimer() {
    this.interval = setInterval(() => {
      if(this.timeLeft > 0) {
        this.timeLeft--;
        if (this.isScrol) {
          // Time to scrol to next page
          if (this.timeLeft % this.scrolInterval === 0) {
            if (this.pageCounter < this.pageCount && this.pageToShowTo === 0 ? true : this.pageCounter < this.pageToShowTo)
              this.pageCounter++;
            else
              this.pageCounter = this.pageToShowFrom === 0 ? 1 : this.pageToShowFrom;
            //console.log('scrol to page #' + this.pageCounter);
            this.goToPage(this.pageCounter);
          }
        }
      } else {
        this.timeLeft = this.updatePeriod * 60;
        this.loadinfoScreensWarehouse();
        this.updateTime = new Date();
      }
    },1000)
  }

  pauseTimer() {
    clearInterval(this.interval);
  }

  getLastUpdateTime() {
    let result: string;
    let now: Date = new Date();
    if (this.isLoadComplete) {
      let hours:number = this.updateTime.getHours();
      let hoursString:string = hours.toString();
      let minutes:number = this.updateTime.getMinutes();
      let minutesString:string = minutes.toString();
      if (minutes < 10)
        minutesString = '0' + minutesString;
      if ( (this.updateTime.getDay.toString() + this.updateTime.getMonth.toString() + this.updateTime.getFullYear.toString()) === (now.getDay.toString() + now.getMonth.toString() + now.getFullYear.toString()))
        result = 'сегодня в ' + hoursString + ':' + minutesString;
      else
        result = this.updateTime.toLocaleString('ru-RU');
    } else {
      result = "в процессе..."
    }
    return result;
  }

  goToScreenChooser() {
    this._ui.stopProgressBarLoading();
    this.router.navigateByUrl('/screenChooser');  
  }

  openFullscreen() {
    console.log(this.divRef);
    const elem = this.divRef.nativeElement;

    if (elem.requestFullscreen) {
      elem.requestFullscreen();
    } else if (elem.msRequestFullscreen) {
      elem.msRequestFullscreen();
    } else if (elem.mozRequestFullScreen) {
      elem.mozRequestFullScreen();
    } else if (elem.webkitRequestFullscreen) {
      elem.webkitRequestFullscreen();
    }
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
