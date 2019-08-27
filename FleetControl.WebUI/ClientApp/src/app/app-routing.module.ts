import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomeComponent} from './home/home.component';
import {CustomerComponent} from './customer/customer.component';

// import { CustomersComponent } from './customers/customers.component';
// import { HomeComponent } from './home/home.component';
// import { ProductsComponent } from './products/products.component';
// import { OrdersComponent } from './orders/orders.component';

const routes: Routes =  [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'customers', component: CustomerComponent },
  // { path: 'products', component: ProductsComponent },
  // { path: 'orders', component: OrdersComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
