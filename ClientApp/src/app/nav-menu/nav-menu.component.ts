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
    this._ui.navbar.subscribe((isVisible: boolean) => { this.navbarSetVisible(isVisible) });
    this._ui.progressbar.subscribe((value: number) => { this.progressbarSetValue(value) });
    //this._ui.progressbar.subscribe((isVisible: boolean) => { this.navbarSetVisible(isVisible) });
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