import { Component } from '@angular/core';
import { CustomersClient, CustomerOrderListViewModel, ProductsListViewModel, ProductsClient } from '../northwind-traders-api';

@Component({
  templateUrl: './orders.component.html'
})
export class OrdersComponent {
  orders: any[];
  customerOrderListViewModel: CustomerOrderListViewModel = new CustomerOrderListViewModel();

  constructor(private customerClient: CustomersClient) {

    customerClient.getOrders('ALFKI').subscribe(
      result => {
        this.customerOrderListViewModel = result;
        console.log(result);
      },
      error => {

      }
    );

  }

}
