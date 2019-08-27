import {Component, Inject, OnInit} from '@angular/core';
import { HttpClient, HttpClientModule, HttpParams } from '@angular/common/http';
import { DxDataGridModule } from 'devextreme-angular';
import DataSource from 'devextreme/data/data_source';
import CustomStore from 'devextreme/data/custom_store';
// import 'rxjs/add/operator/toPromise';



@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styles: []
})


export class CustomerComponent implements OnInit {

  saleAmountHeaderFilter: any;
  applyFilterTypes: any;
  currentFilter: any;
  showFilterRow: boolean;
  showHeaderFilter: boolean;

  ngOnInit(): void {
    
  }
  gridDataSource: any = {};
    constructor(@Inject(HttpClient) httpClient: HttpClient) {
        function isNotEmpty(value: any): boolean {
            return value !== undefined && value !== null && value !== '';
        }
        this.gridDataSource = new DataSource({
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
                ].forEach(function(i) {
                    if(i in loadOptions && isNotEmpty(loadOptions[i])) 
                        params = params.set(i, JSON.stringify(loadOptions[i]));
                });
                return httpClient.get('http://localhost:52467/api/FleetCustomers/DxGrid', { params: params })
                    .toPromise()
                    .then((result: any) => {
                        return {
                            data: result.data,
                            totalCount: result.totalCount,
                            summary: result.summary,
                            groupCount: result.groupCount
                        };
                    });
            }
        });
    }
  }
