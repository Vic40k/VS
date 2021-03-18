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
    this.loadProducts();    // загрузка данных при старте компонента  
  }
  // получаем данные через сервис
  loadProducts() {
    //this.factoryComponents.push({ articul: '1', asCh: 2, asVvod: 3 });
    this.dataService.getFactoryComponents()
      .subscribe((data: FactoryComponent[]) => { this.factoryComponents = data; this.ref.detectChanges(); console.log(this.factoryComponents); });

   
    //console.log(this.factoryComponents);
  }
  // сохранение данных
  /*
  save() {
    if (this.product.id == null) {
      this.dataService.createProduct(this.product)
        .subscribe((data: Product) => this.products.push(data));
    } else {
      this.dataService.updateProduct(this.product)
        .subscribe(data => this.loadProducts());
    }
    this.cancel();
  }
  editProduct(p: Product) {
    this.product = p;
  }
  cancel() {
    this.product = new Product();
    this.tableMode = true;
  }
  delete(p: Product) {
    this.dataService.deleteProduct(p.id)
      .subscribe(data => this.loadProducts());
  }
  add() {
    this.cancel();
    this.tableMode = false;
  }
  */
}
