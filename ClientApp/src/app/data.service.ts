import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { FactoryComponent } from './factoryComponent';

@Injectable()
export class DataService {

  private url = "/api/factoryComponents";

  // Information screens controller
  private infoScreenURL = "/api/info-screens/GetWarehouseInfo";

  constructor(private http: HttpClient) {
  }

  // ------------------------------------------------------- INFORMATION SCREENS -------------------------------------------------------- //
  getWarehouseInfo() {
    const params = new HttpParams()
    .set('factoryId', '44')
    .set('productGroupId', '0')
    .set('productSubGroupId', '99');
    return this.http.get(this.infoScreenURL, {params});
  }


  // ------------------------------------------ DEV ----
  getFactoryComponents() {
    return this.http.get(this.url);
  }

  getFactoryComponent(articul: string) {
    return this.http.get(this.url + '/' + articul);
  }

  createFactoryComponent(FactoryComponent: FactoryComponent) {
    return this.http.post(this.url, FactoryComponent);
  }
  updateFactoryComponent(FactoryComponent: FactoryComponent) {

    return this.http.put(this.url, FactoryComponent);
  }
  deleteFactoryComponent(articul: string) {
    return this.http.delete(this.url + '/' + articul);
  }
}
