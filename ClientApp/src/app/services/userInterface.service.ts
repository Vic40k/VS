import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

// User interface controls
@Injectable()
export class UserIntarfaceService {

    private _loaderSource:any = new BehaviorSubject<any>({});
    public navbar = this._loaderSource.asObservable();
    public progressbar = this._loaderSource.asObservable();

    private progressbarMode:number = 0; 

    // ------- Upper main navigation bar
    setNavbarVisible(isNavbarVisible: boolean){
        this._loaderSource.next(isNavbarVisible);
    }

    // --------- Upper main progress bar
    setProgressbarValue(progressbarValue: number){
        if (progressbarValue >= 0 && progressbarValue <= 100)
            this._loaderSource.next(progressbarValue);
    }

    setProgressBarNormalLoading(){
        this.progressbarMode = 1
        this._loaderSource.next(this.progressbarMode);
    }

    stopProgressBarLoading(){
        this.progressbarMode = 0
        this._loaderSource.next(this.progressbarMode);
    }
}