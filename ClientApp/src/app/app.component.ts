import { Component, OnInit } from '@angular/core';
import { SignalRService } from './services/broadcastService';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(public signalRService: SignalRService, private http: HttpClient) { }
  public isListen: boolean = false;
  ngOnInit() {
    if (this.isListen) {
      this.signalRService.startConnection();
      this.signalRService.addTransferChartDataListener();   
      this.startHttpRequest();
    }
  }
  private startHttpRequest = () => {
    if (this.isListen) {
      this.http.get('https://localhost:44328/api/info-screens/ForceUpdateAllWarehouseScreens')
        .subscribe(res => {
          console.log(res);
        })
    }
  }
}