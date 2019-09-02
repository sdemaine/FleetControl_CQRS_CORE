import { Component, OnInit } from '@angular/core';
import { FleetService } from 'app/shared/fleet.service'
import { KeyValue } from '@angular/common';
import { KeyValuePair } from 'app/shared/key-value-pair.model';
import { FleetAppOptions } from 'app/shared/fleet-app-options.model';

@Component({
  selector: 'app-driver-records',
  templateUrl: './driver-records.component.html',
  styles: []
})
export class DriverRecordsComponent implements OnInit {

  pageTitle = "Drivers";
  // columns: any = ['id', 'firstName', 'lastName', 'theirEmployeeNumber']
  columns: any;
  fleetAppOptions: FleetAppOptions;

  optionalParams: KeyValuePair[] = new Array();

  dataSource = this.fleetSvc.getDevExpressDriverDatasource(this.optionalParams);

  constructor(private fleetSvc: FleetService) {
    this.fleetAppOptions = fleetSvc.getFleetAppOptions();
    this.optionalParams.push({key: 'customerId', value: this.fleetAppOptions.customerId.toString()});
   }

  ngOnInit() {
  }

}
