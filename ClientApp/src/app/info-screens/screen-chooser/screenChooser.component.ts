import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { faDesktop } from '@fortawesome/free-solid-svg-icons';
import { faPencilAlt } from '@fortawesome/free-solid-svg-icons';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
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
  faPencilAlt = faPencilAlt;
  faTrash = faTrash;

  ngOnInit(): void {
    this.loadScreensPreferences();
  }

  // - Gathering data from service
  loadScreensPreferences() {
    this.dataService.getWarehouseScreensPreferences()
      .subscribe((data: []) => 
      { 
        this.screensList = data; 
      });
  }

  // - Return string to show for pageg range
  showPagesPreferences(pageToShowFrom : number, pageToShowTo: number) {
    const all = 'Все';
    let showFromString: string, showToString: string;
    if (pageToShowFrom === 0)
       showFromString = all;
    else 
      showFromString = pageToShowFrom.toString();
    if (pageToShowTo === 0 || pageToShowTo < pageToShowFrom)
      showToString = all;
    else
      showToString = pageToShowTo.toString();
    if (showToString === all && showFromString === all)
      return all;
    else if (pageToShowTo === pageToShowFrom)
      return pageToShowTo.toString();
    else 
      return showFromString + '-' + showToString;
  }

  // - Edit screen preferences
  editScreen(id: number) {
    console.log(id);
  }

  // - Remove screen preference set
  removeScreen(id: number) {
    console.log(id);
  }

  goToWarehouseScreen(id: number = 0) {
    let url: string = '/sklad/0';
    if (this.screensList[id]) {
      url += '?autoScroll=' + this.screensList[id].autoScroll.toString();
      url += '&pageToShowFrom=' + this.screensList[id].pageToShowFrom.toString();
      url += '&pageToShowTo=' + this.screensList[id].pageToShowTo.toString();
      url += '&scrolInterval=' + this.screensList[id].scrollInterval.toString();
      url += '&updatePeriod=' + this.screensList[id].updatePeriod.toString();

      this.router.navigateByUrl(url);  
    }
  }
}

