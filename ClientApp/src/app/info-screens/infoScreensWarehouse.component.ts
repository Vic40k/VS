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
  rowData: [];
  private subscription: Subscription;
  private querySubscription: Subscription;
  //tableMode: boolean = true; 
  updatePeriod: number = 60; // seconds
  timeLeft: number = this.updatePeriod;
  interval;
  updateTime: Date = new Date();

  constructor(private ref: ChangeDetectorRef, private dataService: DataService, private activateRoute: ActivatedRoute) { }

  ngOnInit() {
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
        this.rowData = data; 
        this.ref.detectChanges(); 
        console.log(this.rowData); 
      });
  }

  // - Update info by timer
  startTimer() {
    this.interval = setInterval(() => {
      if(this.timeLeft > 0) {
        this.timeLeft--;
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
