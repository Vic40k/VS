import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { FactoryComponent } from '../factoryComponent';
import { DataWarehouseService } from 'src/app/services/dataWarehouse.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  providers: [DataWarehouseService]
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public factoryComponent: FactoryComponent[];

  constructor(http: HttpClient, private dataService: DataWarehouseService, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
      this.forecasts = result;

      this.dataService.getFactoryComponents()
        .subscribe((data: FactoryComponent[]) => this.factoryComponent = data );

    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
