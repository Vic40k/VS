import { Injectable } from '@angular/core';
import * as signalR from "@microsoft/signalr";

@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  public data: BroadcastModel[];
  public isListen: boolean = false;

private hubConnection: signalR.HubConnection

  public startConnection = () => {
    if (this.isListen) {
      this.hubConnection = new signalR.HubConnectionBuilder()
                              .withUrl('https://localhost:44328/notify')
                              .build();

      this.hubConnection
        .start()
        .then(() => console.log('Connection started'))
        .catch(err => console.log('Error while starting connection: ' + err))
    }
  }

  public addTransferChartDataListener = () => {
    if (this.isListen) {
      this.hubConnection.on('transferchartdata', (data) => {
        this.data = data;
        console.log(data);
      });
    }
  }
}

export interface BroadcastModel {
    data: [],
    label: string
}