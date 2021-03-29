import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './screenChooser.component.html'
})
export class ScreenChooserComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
