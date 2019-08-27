import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './/app-routing.module';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavTopMenuComponent } from './nav-top-menu/nav-top-menu.component';
import { NavSideMenuComponent } from './nav-side-menu/nav-side-menu.component';

import { CustomersClient, ProductsClient } from './northwind-traders-api';

import { CamelCaseToText } from '../pipes/camel-case-to-text';

import { ModalModule } from 'ngx-bootstrap/modal';
import { CustomerComponent } from './customer/customer.component';
import {DxBulletModule, DxButtonModule, DxDataGridModule, DxTemplateModule} from 'devextreme-angular';


const modules = [
  BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
  HttpClientModule,
  FormsModule,
  AppRoutingModule,
  ModalModule.forRoot(),
  DxDataGridModule,
  DxTemplateModule,
  DxBulletModule
];
const components = [
  AppComponent,
  NavTopMenuComponent,
  NavSideMenuComponent,
  HomeComponent,
];
const pipes = [CamelCaseToText];

@NgModule({
  declarations: [...components, ...pipes, CustomerComponent],
  imports: [
    ...modules,
    DxButtonModule
  ],
  providers: [CustomersClient, ProductsClient],
  entryComponents: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
