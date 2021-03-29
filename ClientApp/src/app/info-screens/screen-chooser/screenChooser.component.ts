import { Component } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-counter-component',
  templateUrl: './screenChooser.component.html',
  styleUrls: ['./screenChooser.component.css'],
})
export class ScreenChooserComponent {
  constructor(private router: Router) {}

  goToWarehouseScreen(warehouseMonitorId: number = 0) {
    this.router.navigateByUrl('/sklad/' + warehouseMonitorId);  
  }
}

