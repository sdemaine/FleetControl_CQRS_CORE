import { Component, OnInit, HostListener } from '@angular/core';
import { FleetService } from 'app/shared/fleet.service'

@Component({
  selector: 'app-devexpress-sample-grid',
  templateUrl: './devexpress-sample-grid.component.html',
  styles: []
})
export class DevexpressSampleGridComponent implements OnInit {

  pageTitle = "Drivers";
  // columns: any = ['id', 'firstName', 'lastName', 'theirEmployeeNumber']
  columns: any;
  dataSource = this.fleetSvc.getDevExpressDriverDatasource();
  gridWidth: any;
  gridHeight: any;
  windowWidth: any;
  windowHeight: any;

  constructor(private fleetSvc: FleetService) { }

  ngOnInit() {
    this.windowWidth = window.innerWidth;
    this.windowHeight = window.innerHeight;
    this.gridWidth = this.windowWidth - 100;
    this.gridHeight = this.windowHeight - 100;
  }

  @HostListener('window:resize', ['$event'])
    onResize(event) {
      console.log('resizing window: ' + window.innerWidth);
      this.windowWidth = window.innerWidth;
      this.windowHeight = window.innerHeight;
      this.gridWidth = this.windowWidth - 100;
      this.gridHeight = this.windowHeight - 100;
    }

}
