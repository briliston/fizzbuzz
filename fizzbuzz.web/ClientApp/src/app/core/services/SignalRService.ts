import { Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@microsoft/signalr';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root',
})
export class SignalRService {

  connectionToHub: HubConnection | undefined;

  constructor() { }

  startConnection = () => {
      this.connectionToHub = new HubConnectionBuilder()
      .withUrl(`https://localhost:${environment.ASPNETCORE_HTTPS_PORT}/fizzbuzzHub`)
      .build();

      this.connectionToHub.start()
      .then(() => {
        console.log(this.connectionToHub?.connectionId);
        console.log('SignalR Connection Started');
      })
      .catch(err => console.log('Error while starting signalR connection ' + err));
  }

  stopConnection = () => {
    this.connectionToHub && this.connectionToHub.stop()
      .then(() => console.log('SignalR Connection Stopped'))
      .catch(err => console.log('Error while stopping signalR connection ' + err));
  }
}