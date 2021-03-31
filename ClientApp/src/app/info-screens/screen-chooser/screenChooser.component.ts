import { Component } from '@angular/core';
import {Router} from '@angular/router';
import { faDesktop } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-counter-component',
  templateUrl: './screenChooser.component.html',
  styleUrls: ['./screenChooser.component.css'],
})
export class ScreenChooserComponent {
  constructor(private router: Router) {}

  faDesktop = faDesktop;

  goToWarehouseScreen(warehouseMonitorId: number = 0) {
    this.router.navigateByUrl('/sklad/0?autoScroll=true&pageToShow=0&pageToShowFrom=0&pageToShowTo=0&scrolInterval=5&updatePeriod=60&resultQty=0');  
  }
}

