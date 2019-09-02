import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HttpClient } from '@angular/common/http';
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
import { DxBulletModule, DxButtonModule, DxDataGridModule, DxTemplateModule, DxMenuModule, DxSelectBoxModule, DxCheckBoxModule, DxTreeListModule } from 'devextreme-angular';
import { FleetControlGridComponent } from './shared/fleet-control-grid/fleet-control-grid.component';
import { VehicleComponent } from './vehicle/vehicle.component';
import { ProductComponent } from './product/product.component';
import { MenuComponent } from './navigation/menu/menu.component';
import { CustomerRecordsComponent } from './customer/customer-records/customer-records.component';
import { CardRecordsComponent } from './customer/card-records/card-records.component';
import { VehicleRecordsComponent } from './customer/vehicle-records/vehicle-records.component';
import { DriverRecordsComponent } from './customer/driver-records/driver-records.component';
import { TransactionDetailComponent } from './reporting/transaction-detail/transaction-detail.component';
import { TransactionErrorLogComponent } from './reporting/transaction-error-log/transaction-error-log.component';
import { ManualTransactionEntryComponent } from './reporting/manual-transaction-entry/manual-transaction-entry.component';
import { FuelManagementReportComponent } from './reporting/fuel-management-report/fuel-management-report.component';
import { TransactionExceptionReportComponent } from './reporting/transaction-exception-report/transaction-exception-report.component';
import { CardReportComponent } from './reporting/card-report/card-report.component';
import { VehicleReportComponent } from './reporting/vehicle-report/vehicle-report.component';
import { DriverReportComponent } from './reporting/driver-report/driver-report.component';
import { TransactionSendErrorsComponent } from './reporting/transaction-send-errors/transaction-send-errors.component';
import { FleetExportComponent } from './data-export/fleet-export/fleet-export.component';
import { CardShipmentAddressesComponent } from './reference-data/card-shipment-addresses/card-shipment-addresses.component';
import { LocationsComponent } from './reference-data/locations/locations.component';
import { CustomerCardTypesComponent } from './reference-data/customer-card-types/customer-card-types.component';
import { CustomerPricingGroupsComponent } from './reference-data/customer-pricing-groups/customer-pricing-groups.component';
import { LocationPricingGroupsComponent } from './reference-data/location-pricing-groups/location-pricing-groups.component';
import { ProductCodesComponent } from './reference-data/product-codes/product-codes.component';
import { PurchaseOrdersComponent } from './reference-data/purchase-orders/purchase-orders.component';
import { RetailAddersComponent } from './reference-data/retail-adders/retail-adders.component';
import { SecurityComponent } from './admin/security/security.component';
import { CustomerCardCategoriesComponent } from './admin/customer-card-categories/customer-card-categories.component';
import { DamCardMaintenanceComponent } from './admin/dam-card-maintenance/dam-card-maintenance.component';
import { DamVehicleMaintenanceComponent } from './admin/dam-vehicle-maintenance/dam-vehicle-maintenance.component';
import { DamDriverMaintenanceComponent } from './admin/dam-driver-maintenance/dam-driver-maintenance.component';
import { BusinessHoursComponent } from './customer/customer-admin/business-hours/business-hours.component';
import { DepartmentsComponent } from './customer/customer-admin/departments/departments.component';
import { FleetService } from './shared/fleet.service';
import { DevexpressSampleGridComponent } from './shared/devexpress-sample-grid/devexpress-sample-grid.component';


const modules = [
  BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
  HttpClientModule,
  FormsModule,
  AppRoutingModule,
  ModalModule.forRoot(),
  DxDataGridModule,
  DxTemplateModule,
  DxBulletModule,
  DxMenuModule,
  DxSelectBoxModule,
  DxCheckBoxModule,
  DxTreeListModule
];
const components = [
  AppComponent,
  NavTopMenuComponent,
  NavSideMenuComponent,
  HomeComponent,
];
const pipes = [CamelCaseToText];

@NgModule({
  declarations: [...components, ...pipes, CustomerComponent, CardRecordsComponent, FleetControlGridComponent, DepartmentsComponent, VehicleComponent, ProductComponent, MenuComponent, CustomerRecordsComponent, CardRecordsComponent, VehicleRecordsComponent, DriverRecordsComponent, TransactionDetailComponent, TransactionErrorLogComponent, ManualTransactionEntryComponent, FuelManagementReportComponent, TransactionExceptionReportComponent, CardReportComponent, VehicleReportComponent, DriverReportComponent, TransactionSendErrorsComponent, FleetExportComponent, CardShipmentAddressesComponent, LocationsComponent, CustomerCardTypesComponent, CustomerPricingGroupsComponent, LocationPricingGroupsComponent, ProductCodesComponent, PurchaseOrdersComponent, RetailAddersComponent, SecurityComponent, CustomerCardCategoriesComponent, DamCardMaintenanceComponent, DamVehicleMaintenanceComponent, DamDriverMaintenanceComponent, BusinessHoursComponent, DepartmentsComponent, DevexpressSampleGridComponent],
  imports: [
    ...modules,
    DxButtonModule
  ],
  providers: [HttpClient, CustomersClient, ProductsClient, FleetService],
  entryComponents: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
