import { Component } from '@angular/core';
import { ProductsClient, ProductsListViewModel, CustomersClient } from '../northwind-traders-api';

@Component({
  templateUrl: './products.component.html'
})
export class ProductsComponent {

  productsListVm: ProductsListViewModel = new ProductsListViewModel();

  constructor(client: ProductsClient) {
    client.getAll().subscribe(result => {
      this.productsListVm = result;
      console.log(result);
    }, error => console.error(error));
  }
}
