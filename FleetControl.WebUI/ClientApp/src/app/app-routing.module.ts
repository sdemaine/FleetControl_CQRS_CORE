import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomeComponent} from './home/home.component';
import { CustomerCardCategoriesComponent } from './admin/customer-card-categories/customer-card-categories.component';
import { CardRecordsComponent } from './customer/card-records/card-records.component';
import { VehicleRecordsComponent } from './customer/vehicle-records/vehicle-records.component';
import { CustomerRecordsComponent } from './customer/customer-records/customer-records.component';
import { DriverRecordsComponent } from './customer/driver-records/driver-records.component';
import { BusinessHoursComponent } from './customer/customer-admin/business-hours/business-hours.component';
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
import { DamCardMaintenanceComponent } from './admin/dam-card-maintenance/dam-card-maintenance.component';
import { DamVehicleMaintenanceComponent } from './admin/dam-vehicle-maintenance/dam-vehicle-maintenance.component';
import { DamDriverMaintenanceComponent } from './admin/dam-driver-maintenance/dam-driver-maintenance.component';
import { DepartmentsComponent } from './customer/customer-admin/departments/departments.component';
import { DevexpressSampleGridComponent } from './shared/devexpress-sample-grid/devexpress-sample-grid.component';

const routes: Routes =  [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },

  { path: 'customer/customer-records', component: CustomerRecordsComponent },
  { path: 'customer/card-records', component: CardRecordsComponent },
  { path: 'customer/vehicle-records', component: VehicleRecordsComponent },
  { path: 'customer/driver-records', component: DriverRecordsComponent },

  { path: 'customer/customer-admin/business-hours', component: BusinessHoursComponent },
  { path: 'customer/customer-admin/departments', component: DepartmentsComponent },

  { path: 'reporting/transaction-details', component: TransactionDetailComponent },
  { path: 'reporting/transaction-error-log', component: TransactionErrorLogComponent },
  { path: 'reporting/manual-transaction-entry', component: ManualTransactionEntryComponent },
  { path: 'reporting/fuel-management-report', component: FuelManagementReportComponent },
  { path: 'reporting/transaction-exception-report', component: TransactionExceptionReportComponent },
  { path: 'reporting/card-report', component: CardReportComponent },
  { path: 'reporting/vehicle-report', component: VehicleReportComponent },
  { path: 'reporting/driver-report', component: DriverReportComponent },
  { path: 'reporting/transaction-send-errors', component: TransactionSendErrorsComponent },

  { path: 'data-export/fleet-export', component: FleetExportComponent },

  { path: 'reference-data/card-shipment-addresses', component: CardShipmentAddressesComponent },
  { path: 'reference-data/locations', component: LocationsComponent },
  { path: 'reference-data/customer-card-types', component: CustomerCardTypesComponent },
  { path: 'reference-data/customer-pricing-groups', component: CustomerPricingGroupsComponent },
  { path: 'reference-data/location-pricing-groups', component: LocationPricingGroupsComponent },
  { path: 'reference-data/product-codes', component: ProductCodesComponent },
  { path: 'reference-data/purchase-orders', component: PurchaseOrdersComponent },
  { path: 'reference-data/retail-adders', component: RetailAddersComponent },

  { path: 'admin/customer-card-categories', component: CustomerCardCategoriesComponent },
  { path: 'admin/security', component: SecurityComponent },
  
  { path: 'admin/account-maintenance/dam-card-maintenance', component: DamCardMaintenanceComponent },
  { path: 'admin/account-maintenance/dam-vehicle-maintenance', component: DamVehicleMaintenanceComponent },
  { path: 'admin/account-maintenance/dam-driver-maintenance', component: DamDriverMaintenanceComponent },

  { path: 'sample-data-grid', component: DevexpressSampleGridComponent },
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
