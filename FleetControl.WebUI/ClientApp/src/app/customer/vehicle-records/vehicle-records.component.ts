import { Component, OnInit } from '@angular/core';
import { FleetService } from 'app/shared/fleet.service';
import { FleetAppOptions } from 'app/shared/fleet-app-options.model';
import { KeyValuePair } from 'app/shared/key-value-pair.model';

@Component({
  selector: 'app-vehicle-records',
  templateUrl: './vehicle-records.component.html',
  styles: []
})
export class VehicleRecordsComponent implements OnInit {

  pageTitle = "Vehicles";
  // columns: any = ['vehicleDescription', 'theirVehicleNumber']
  columns: any;
  fleetAppOptions: FleetAppOptions;
  
  optionalParams: KeyValuePair[] = new Array();
  dataSource = this.fleetSvc.getDevExpressVehicleDatasource(this.optionalParams);

  constructor(private fleetSvc: FleetService) {
    this.fleetAppOptions = fleetSvc.getFleetAppOptions();
    this.optionalParams.push({key: 'customerId', value: this.fleetAppOptions.customerId.toString()});
   }

  ngOnInit() {
  }

}
