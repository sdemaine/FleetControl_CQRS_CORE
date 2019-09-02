import { Component, OnInit } from '@angular/core';
import { FleetService } from 'app/shared/fleet.service';

import DataSource from 'devextreme/data/data_source';
import { HttpParams, HttpClient } from '@angular/common/http';
import { KeyValuePair } from 'app/shared/key-value-pair.model';
import { FleetAppOptions } from 'app/shared/fleet-app-options.model';

@Component({
  selector: 'app-customer-records',
  templateUrl: './customer-records.component.html',
  styles: []
})
export class CustomerRecordsComponent implements OnInit {

  pageTitle = "Customers";
  columns: any = ['customerName']
  dataSource: any;

  parameters: KeyValuePair[] = new Array();

  

  constructor(private fleetSvc: FleetService, private http: HttpClient) { }

  ngOnInit() {
    // parameters: KeyValuePair[] = new Array();
    this.parameters.push(new KeyValuePair("baid", "1234"));
    this.parameters.push(new KeyValuePair("customerId", "101"));
    this.dataSource = this.fleetSvc.getDevExpressCustomerDatasource(this.parameters);

    let fleetAppOptions: FleetAppOptions = this.fleetSvc.getFleetAppOptions();
    console.log(fleetAppOptions);
  }

  ds = new DataSource({
    key: 'id',
    load: (loadOptions) => {
        let params: HttpParams = new HttpParams();
        [
            'skip',
            'take',
            'requireTotalCount',
            'requireGroupCount',
            'sort',
            'filter',
            'totalSummary',
            'group',
            'groupSummary'
        ].forEach(function (i) {
            if (i in loadOptions)
                params = params.set(i, JSON.stringify(loadOptions[i]));
        });
        
        

        // console.log('params:');
        // console.log(params.set("baid", "1234"));
        // params = params.append("baid", "1234");
        // console.log(params);
        return this.http.get('http://localhost:52467/api/', { params: params })
            .toPromise()
            .then((result: any) => {
                return {
                    data: result.data,
                    totalCount: result.totalCount,
                    summary: result.summary,
                    groupCount: result.groupCount
                };
            }
            );
          }})
    

}
