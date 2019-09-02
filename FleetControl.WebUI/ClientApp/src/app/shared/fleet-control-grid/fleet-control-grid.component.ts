import { Component, OnInit, Input, HostListener } from '@angular/core';

@Component({
  selector: 'app-fleet-control-grid',
  templateUrl: './fleet-control-grid.component.html',
  styleUrls: ['./fleet-control-grid.component.css']
})
export class FleetControlGridComponent implements OnInit {

  constructor() { }

  @Input() gridName: string;
  @Input() dataSource: string;
  @Input() columns: string[];

  currentFilter: any;

  gridWidth: any;
  gridHeight: any;
  windowWidth: any;
  windowHeight: any;


  ngOnInit() {
    this.windowWidth = window.innerWidth;
    this.windowHeight = window.innerHeight;
    this.gridWidth = this.windowWidth - 100;
    this.gridHeight = this.windowHeight - 170;
  }

  @HostListener('window:resize', ['$event'])
    onResize(event) {
      console.log('resizing window: ' + window.innerWidth);
      this.windowWidth = window.innerWidth;
      this.windowHeight = window.innerHeight;
      this.gridWidth = this.windowWidth - 100;
      this.gridHeight = this.windowHeight - 170;
    }

}
