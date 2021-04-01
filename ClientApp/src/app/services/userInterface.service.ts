import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { FormControl } from '@angular/forms';
import { TooltipPosition } from '@angular/material/tooltip';

// User interface controls
@Injectable()
export class UserIntarfaceService {

    private _navbarSource:any = new BehaviorSubject<any>({});
    private _progressbarSource:any = new BehaviorSubject<any>({});
    public navbar = this._navbarSource.asObservable();
    public progressbar = this._progressbarSource.asObservable();

    private progressbarMode:number = 0; 

    // ------- Upper main navigation bar
    setNavbarVisible(isNavbarVisible: boolean){
        this._navbarSource.next(isNavbarVisible);
    }

    // --------- Upper main progress bar
    setProgressbarValue(progressbarValue: number){
        if (progressbarValue >= 0 && progressbarValue <= 100){
            this.stopProgressBarLoading();
            this._progressbarSource.next(progressbarValue);
        }
    }

    setProgressBarNormalLoading(){
        this.progressbarMode = 1
        this._progressbarSource.next(this.progressbarMode);
    }

    stopProgressBarLoading(){
        this.progressbarMode = 0
        this._progressbarSource.next(this.progressbarMode);
    }

    // Dictionary for mat-tooltip
    positionOptions: TooltipPosition[] = ['after', 'before', 'above', 'below', 'left', 'right'];
    position = new FormControl(this.positionOptions[0]);
}