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
  isExpanded: boolean = false;
  isVisible: boolean = true;
  
  ngOnInit() {
    this._ui.navbar.subscribe((load: boolean) => { this.isVisible = load });
  }

  // ---- Internal functions
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}