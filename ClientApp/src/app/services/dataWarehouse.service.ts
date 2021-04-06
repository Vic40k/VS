import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { FactoryComponent } from '../factoryComponent';

@Injectable()
export class DataWarehouseService {

  private url = "/api/factoryComponents";

  // Information screens controller
  private readonly warehouseScreensDataURL = "/api/info-screens/GetWarehouseInfo";
  private readonly getInfoSreensPref = "/api/info-screens/GetScreensPreferences";
  private readonly updInfoSreensPref = "/api/info-screens/UpdateScreenPreferences";
  private readonly delInfoSreensPref = "/api/info-screens/DeleteScreensPreference";

  constructor(private http: HttpClient) {
  }

  // ------------------------------------------------------- INFORMATION SCREENS -------------------------------------------------------- //
  getWarehouseInfo() {
    const params = new HttpParams()
    .set('factoryId', '44')
    .set('productGroupId', '0')
    .set('productSubGroupId', '99');
    return this.http.get(this.warehouseScreensDataURL, {params});
  }

  getWarehouseScreensPreferences() {
    return this.http.get(this.getInfoSreensPref);
  }

  deleteWarehouseInfo(id: number) {
    const params = new HttpParams()
    .set('id', id.toString())
    return this.http.get(this.delInfoSreensPref, {params});
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
