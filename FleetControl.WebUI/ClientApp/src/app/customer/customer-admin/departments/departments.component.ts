import { Component, OnInit } from '@angular/core';
import { FleetService } from 'app/shared/fleet.service';
import { KeyValuePair } from 'app/shared/key-value-pair.model';

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styles: []
})
export class DepartmentsComponent implements OnInit {

  pageTitle = "Departments";
  //columns: any = ['firstName', 'lastName']
  parameters: KeyValuePair[] = new Array();
  dataSource:any;

  constructor(private fleetSvc: FleetService) { }

  ngOnInit() {
    
    this.parameters.push(new KeyValuePair("baid", "1234"));
    this.parameters.push(new KeyValuePair("customerId", "101"));
    this.dataSource = this.fleetSvc.getDevExpressOrgLevelDefinitionDatasource(this.parameters);
  }

}
