import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './screenChooser.component.html',
  styleUrls: ['./screenChooser.component.css'],
})
export class ScreenChooserComponent {
  
  goToWarehouseScreen(warehouseMonitorId: number = 0) {
    alert(warehouseMonitorId);
  }
}

