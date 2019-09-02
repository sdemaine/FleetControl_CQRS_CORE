import { Component, OnInit } from '@angular/core';
import { FleetService } from '../shared/fleet.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html'
})
export class CustomerComponent implements OnInit {

  pageTitle = "Customers";
  columns: any = ['customerName', 'address']
  dataSource = this.fleetSvc.getDevExpressCustomerDatasource();

  constructor(private fleetSvc: FleetService) { }

  ngOnInit() {
  }

}
