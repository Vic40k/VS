import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { FactoryComponent } from '../factoryComponent';

@Component({
  selector: 'app',
  templateUrl: './factoryComponents.component.html',
  providers: [DataService]
})
export class FactoryComponentsComponent implements OnInit {

  factoryComponent: FactoryComponent = new FactoryComponent();   // изменяемый товар
  factoryComponents: FactoryComponent[];                // массив товаров
  tableMode: boolean = true;          // табличный режим

  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadProducts();    // загрузка данных при старте компонента  
  }
  // получаем данные через сервис
  loadProducts() {
    this.dataService.getFactoryComponents()
      .subscribe((data: FactoryComponent[]) => this.factoryComponents = data);
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
