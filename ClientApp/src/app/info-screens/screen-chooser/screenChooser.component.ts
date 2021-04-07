import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { faDesktop } from '@fortawesome/free-solid-svg-icons';
import { faPencilAlt } from '@fortawesome/free-solid-svg-icons';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
import { faCheck } from '@fortawesome/free-solid-svg-icons';
import { faTimesCircle } from '@fortawesome/free-solid-svg-icons';
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
  screenPrefStamp: any = {};

  faDesktop = faDesktop;
  faPencilAlt = faPencilAlt;
  faTrash = faTrash;
  faCheck = faCheck;
  faTimesCircle = faTimesCircle;

  //TODO
  // Validation input, required or form control need
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

  // Return string depends on minutes count
  getMinutesString(minutes: number) {
    if (minutes == 1)
      return "минута";
    else if (minutes >= 2 && minutes < 5)
      return "минуты";
    else
      return "минут";
  }

  // Create url with needed preferences and go to
  goToWarehouseScreen(id: number) {
    let url: string = '/sklad';
    let pref: any = null;
    this.screensList.forEach(function(item){
      if (item.id === id)
        pref = item;
    });
    if (pref !== null) {
      url += '?autoScroll=' + pref.autoScroll.toString();
      url += '&pageToShowFrom=' + pref.pageToShowFrom.toString();
      url += '&pageToShowTo=' + pref.pageToShowTo.toString();
      url += '&scrolInterval=' + pref.scrollInterval.toString();
      url += '&updatePeriod=' + pref.updatePeriod.toString();

      this.router.navigateByUrl(url);  
    }
  }

  // - Edit screen preferences
  editScreen(screen: any) {
    this.screenPrefStamp = Object.assign({}, screen);
    this.resetAllEditFlags();
    screen.isEdit = true;
  }

  // - Remove screen preference set
  removeScreen(id: number) {
    this.dataService.delWarehouseScreensPreferences(id)
    .subscribe(() => 
    { 
      this.loadScreensPreferences();
    });
  }
  
  // - Save screen preference edit
  saveScreenEdit(screen: any) {
    // TODO
    console.log(screen);
    //this.resetAllEditFlags();
  }

  // - Cancel screen preference edit
  cancelScreenEdit(screen: any) {
    // Back all values
    screen.name = this.screenPrefStamp.name;
    this.screenPrefStamp = {};
    this.resetAllEditFlags();
  }

  // - Prevent of opening several preferences for edit
  private resetAllEditFlags() {
    this.screensList.forEach(function(item){
      if (item.isEdit)
        item.isEdit = false;
    });
  }
}

