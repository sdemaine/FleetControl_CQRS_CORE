import { Component, OnInit } from '@angular/core';
import { FleetService } from 'app/shared/fleet.service'

@Component({
  selector: 'app-card-records',
  templateUrl: './card-records.component.html',
  styles: []
})
export class CardRecordsComponent implements OnInit {

  pageTitle = "Cards";
  columns: any = ['theirCardNumber']
  dataSource = this.fleetSvc.getDevExpressCardDatasource();

  constructor(private fleetSvc: FleetService) { }

  ngOnInit() {
  }

}
