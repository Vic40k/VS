import { Component, OnInit } from '@angular/core';
//import { ActivatedRoute } from '@angular/router';
import { UserIntarfaceService } from '../services/userInterface.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit{
  constructor(private _ui: UserIntarfaceService) { }
  // Navbar
  isNavbarExpanded: boolean = false;
  isNavbarVisible: boolean = true;
  // Progressbar
  progressbarValue: number = 10;
  progressbarMode: string = 'determinate';
  ngOnInit() {
    this.resetAllUI();
    this._ui.navbar.subscribe((isNavbarVisible: boolean) => { this.navbarSetVisible(isNavbarVisible) });
    this._ui.progressbar.subscribe((progressbarValue: number) => { this.progressbarSetValue(progressbarValue) });
    this._ui.progressbar.subscribe((progressbarMode: number) => { 
      switch(progressbarMode) {
        case (0):
          this.progressbarSetDetrminate();
          this.progressbarSetValue(0);
          break;
        case (1):
          this.progressbarSetIndetrminate();
          break;
        case (2):
          this.progressbarSetBuffer();
          break;
        case (3):
          this.progressbarSetQuery();
          break;
        default:
          break;
      }
    });
  }

  // ---- Common internal functions
  resetAllUI() {
    this.isNavbarExpanded = false;
    this.isNavbarVisible = true;
    this.progressbarValue = 0;
    this.progressbarMode = 'determinate';
  }

  // ---- Navbar internal functions
  navbarSetVisible(isVisible: boolean) {
    this.isNavbarVisible = isVisible;
  }

  navbarCollapse() {
    this.isNavbarExpanded = false;
  }

  navbarToggle() {
    this.isNavbarExpanded = !this.isNavbarExpanded;
  }

  // ----- Progressbar internal functions
  progressbarSetValue(value: number) {
    this.progressbarValue = value;
  }

  progressbarSetDetrminate() {
    this.progressbarMode = 'determinate';
  }

  progressbarSetIndetrminate() {
    this.progressbarMode = 'indeterminate';
  }

  progressbarSetBuffer() {
    this.progressbarMode = 'buffer';
  }

  progressbarSetQuery() {
    this.progressbarMode = 'query';
  }
}