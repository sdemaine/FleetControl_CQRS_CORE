import { Component, OnInit } from '@angular/core';
import { FleetService } from 'app/shared/fleet.service';

@Component({
  selector: 'app-business-hours',
  templateUrl: './business-hours.component.html',
  styles: []
})
export class BusinessHoursComponent implements OnInit {

  pageTitle = "Business Hours";
  columns2: any = [
    'id',
    'closedSunday', 'closedMonday', 'closedTuesday', 'closedWednesday', 'closedThursday', 'closedFriday', 'closedSaturday',
    'sundayOpen', 'sundayClose','mondayOpen', 'mondayClose', 'tuesdayOpen', 'tuesdayClose', 'wednesdayOpen', 'wednesdayClose', 'thursdayOpen', 'thursdayClose', 'fridayOpen', 'fridayClose', 'saturdayOpen', 'saturdayClose',
    ,'sunday24Hours', 'monday24Hours', 'tuesday24Hours', 'wednesday24Hours', 'thursday24Hours', 'friday24Hours', 'saturday24Hours'
  ]

  columns: any;

  dataSource = this.fleetSvc.getDevExpressBusinessHoursDatasource();

  constructor(private fleetSvc: FleetService) { }

  ngOnInit() {
  }

}
