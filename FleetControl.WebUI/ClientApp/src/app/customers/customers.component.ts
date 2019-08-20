import { Component } from '@angular/core';
import { CustomersClient, CustomersListViewModel } from '../northwind-traders-api';
import { CustomerDetailComponent } from '../customer-detail/customer-detail.component';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html'
})
export class CustomersComponent {

  public vm: CustomersListViewModel = new CustomersListViewModel();
  private bsModalRef: BsModalRef;

  constructor(private client: CustomersClient, private modalService: BsModalService) {
    client.getAll().subscribe(result => {
      this.vm = result;
      console.log(result);
    }, error => console.error(error));
  }

  public customerDetail(id: string) {
    this.client.get(id).subscribe(result => {
      const initialState = {
        customer: result
      };
      this.bsModalRef = this.modalService.show(CustomerDetailComponent, {initialState});
    }, error => console.error(error));
  }
}
