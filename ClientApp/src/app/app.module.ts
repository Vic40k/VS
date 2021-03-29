import { BrowserModule } from '@angular/platform-browser';
import { NgModule, LOCALE_ID } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MDBBootstrapModule } from 'angular-bootstrap-md';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ScreenChooserComponent } from './info-screens/screen-chooser/screenChooser.component';
import { InfoScreensWarehouseComponent } from './info-screens/warehouse/infoScreensWarehouse.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { Page404Component } from './servicePages/page404/page404.component'

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatButtonModule } from '@angular/material/button';

import localeRu from '@angular/common/locales/ru';
import { registerLocaleData } from '@angular/common';

import '@angular/common/locales/global/ru';

registerLocaleData(localeRu);

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ScreenChooserComponent,
    InfoScreensWarehouseComponent,
    Page404Component
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      //Screen chooser
      { path: 'screenChooser', component: ScreenChooserComponent }, // full route
      { path: 'screenChoose', component: ScreenChooserComponent }, // pseudonym
      { path: 'screens', component: ScreenChooserComponent }, // pseudonym
      { path: 'экраны', component: ScreenChooserComponent }, // pseudonym ru
      //Warehouse routes
      { path: 'infoScreensWarehouse/:id', component: InfoScreensWarehouseComponent }, // full route
      { path: 'sklad/:id', component: InfoScreensWarehouseComponent }, // pseudonym
      { path: 'склад/:id', component: InfoScreensWarehouseComponent }, // pseudonym ru

      // debug garbage
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },

      { path: '**', component: Page404Component },  // Wildcard route for a 404 page
    ], { relativeLinkResolution: 'legacy' }),
    MDBBootstrapModule.forRoot(),
    BrowserAnimationsModule,
    MatProgressBarModule,
    MatButtonModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true },
    { provide: LOCALE_ID, useValue: 'ru' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
