import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { FactoryComponent } from '../factoryComponent';
import { DataService } from '../data.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  providers: [DataService]
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public factoryComponent: FactoryComponent[];

  constructor(http: HttpClient, private dataService: DataService, @Inject('BASE_URL') baseUrl: string) {
    http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
      this.forecasts = result;

      this.dataService.getFactoryComponents()
        .subscribe((data: FactoryComponent[]) => this.factoryComponent = data );
      console.log(this.factoryComponent);

    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
