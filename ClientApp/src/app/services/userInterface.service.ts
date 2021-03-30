import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

// User interface controls
@Injectable()
export class UserIntarfaceService {

  private _loaderSource:any = new BehaviorSubject<any>({});
  public navbar = this._loaderSource.asObservable();

  //Upper main navigation bar
  setNavbarVisible(isVisible: boolean){
    this._loaderSource.next(isVisible);
  }
}