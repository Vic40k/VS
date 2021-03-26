//import { ChangeDetectionStrategy } from '@angular/compiler/src/core';
import { ChangeDetectorRef } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { max } from 'rxjs/operators';
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
  dataStorage: [];
  dataShow: [];
  private subscription: Subscription;
  private querySubscription: Subscription;
  //tableMode: boolean = true; 
  updatePeriod: number = 60; // seconds
  timeLeft: number = this.updatePeriod;
  interval;

  isScrol = true;
  scrolInterval = 5; // seconds, must be less than 60 
  maxResultsPerPage = 20;
  pageCount = 1;
  pageCounter = 1;

  updateTime: Date = new Date();

  constructor(private ref: ChangeDetectorRef, private dataService: DataService, private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    // Define params from URL
    this.subscription = this.activateRoute.params.subscribe(params => this.id = params['id']);
    this.querySubscription = this.activateRoute.queryParams.subscribe(
      (queryParam: any) => {
          this.resultQty = queryParam['resultQty'];
      }
    );

    this.loadinfoScreensWarehouse();    // загрузка данных при старте компонента  
    this.startTimer();
  }
  // получаем данные через сервис
  loadinfoScreensWarehouse() {
    this.dataService.getWarehouseInfo()
      .subscribe((data: []) => 
      { 
        this.dataStorage = data; 
        console.log(this.dataStorage);
        // Count pages if needed
        if (this.isScrol)
          this.pageCount = Math.round(this.dataStorage.length / this.maxResultsPerPage) + 1;
        console.log(this.pageCount);
        // Fill array to show in first time
        if (!this.dataShow)
          this.dataShow = Object.assign([], this.dataStorage);
        // Update view
        this.ref.detectChanges(); 
      });
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

  currentShow() {
    console.log('!');
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
