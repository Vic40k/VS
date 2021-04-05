import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { faDesktop } from '@fortawesome/free-solid-svg-icons';
import { DataWarehouseService } from 'src/app/services/dataWarehouse.service';

@Component({
  selector: 'app-counter-component',
  templateUrl: './screenChooser.component.html',
  styleUrls: ['./screenChooser.component.css'],
  providers: [DataWarehouseService],
})
export class ScreenChooserComponent {
  constructor(private router: Router, private dataService: DataWarehouseService ) {}
  screensList: any[];

  faDesktop = faDesktop;

  ngOnInit(): void {
    this.loadinfoScreensPreferences();
  }

  // получаем данные через сервис
  loadinfoScreensPreferences() {
    this.dataService.getWarehouseScreensPreferences()
      .subscribe((data: []) => 
      { 
        this.screensList = data; 
        console.log(data);
      });
  }

  goToWarehouseScreen(warehouseMonitorId: number = 0) {
    if (warehouseMonitorId === 0)
      this.router.navigateByUrl('/sklad/0?autoScroll=true&pageToShow=0&pageToShowFrom=0&pageToShowTo=0&scrolInterval=5&updatePeriod=60&resultQty=0');  
    else if (warehouseMonitorId === 1)
      this.router.navigateByUrl('/sklad/0?autoScroll=false&pageToShow=1&pageToShowFrom=0&pageToShowTo=0&scrolInterval=5&updatePeriod=60&resultQty=0');  
    else if (warehouseMonitorId === 2)
      this.router.navigateByUrl('/sklad/0?autoScroll=true&pageToShow=0&pageToShowFrom=2&pageToShowTo=0&scrolInterval=10&updatePeriod=60&resultQty=0');  
  }
}

