//import { ChangeDetectionStrategy } from '@angular/compiler/src/core';
import { ChangeDetectorRef } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { FactoryComponent } from '../factoryComponent';

@Component({
  selector: 'app-factory-components',
  templateUrl: './factoryComponents.component.html',
  providers: [DataService],
  //changeDetection: ChangeDetectionStrategy.OnPush,
})
export class FactoryComponentsComponent implements OnInit {

  factoryComponent: FactoryComponent = new FactoryComponent();   // изменяемый 
  factoryComponents: FactoryComponent[];                // массив 
  tableMode: boolean = true;          // табличный режим

  constructor(private ref: ChangeDetectorRef, private dataService: DataService) { }

  ngOnInit() {
    this.loadFactoryComponents();    // загрузка данных при старте компонента  
  }
  // получаем данные через сервис
  loadFactoryComponents() {
    //this.factoryComponents.push({ articul: '1', asCh: 2, asVvod: 3 });
    this.dataService.getFactoryComponents()
      .subscribe((data: FactoryComponent[]) => { this.factoryComponents = data; this.ref.detectChanges(); console.log(this.factoryComponents); });

   
    //console.log(this.factoryComponents);
  }

  // сохранение данных
  save() {
    if (this.factoryComponent.articul == null) {
      this.dataService.createFactoryComponent(this.factoryComponent)
        .subscribe((data: FactoryComponent) => this.factoryComponents.push(data));
    } else {
      this.dataService.updateFactoryComponent(this.factoryComponent)
        .subscribe(data => this.loadFactoryComponents());
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
      .subscribe(data => this.loadFactoryComponents());
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }

}
