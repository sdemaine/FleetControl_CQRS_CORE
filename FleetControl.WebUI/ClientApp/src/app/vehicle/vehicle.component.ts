import { Component, OnInit } from '@angular/core';
import { FleetService } from '../shared/fleet.service';

@Component({
  selector: 'app-vehicle',
  templateUrl: './vehicle.component.html'
})
export class VehicleComponent implements OnInit {

  pageTitle = "Vehicles";
  columns: any = ['vehicleDescription', 'theirVehicleNumber']
  dataSource = this.fleetSvc.getDevExpressVehicleDatasource();

  constructor(private fleetSvc: FleetService) { }

  ngOnInit() {
  }

}
