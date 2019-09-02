import { Inject, Injectable, Component, OnInit } from '@angular/core';
import { SESSION_STORAGE, LOCAL_STORAGE, StorageService, StorageTranscoders } from 'ngx-webstorage-service';


import { HttpClient, HttpClientModule, HttpParams, HttpHeaders } from '@angular/common/http';
import { DxDataGridModule, DxDataGridComponent } from 'devextreme-angular';
import DataSource from 'devextreme/data/data_source';
import CustomStore from 'devextreme/data/custom_store';
import { NgModel } from '@angular/forms';
import { getAttrsForDirectiveMatching } from '@angular/compiler/src/render3/view/util';
import { KeyValuePair } from './key-value-pair.model';
import { FleetAppOptions } from './fleet-app-options.model';

@Injectable({
    providedIn: 'root'
})
export class FleetService {

    storage: StorageService;

    constructor(@Inject(LOCAL_STORAGE) storage: StorageService, private http: HttpClient) {
        this.storage = storage;

        // Mimic third party storing a value...
        localStorage.setItem('foo', 'bar');

        let fleetAppOptions = {
            userName: "sdemaine",
            isAuthorized: true,
            customerId: 101,
            customerName: 'Sprague Operating Resources'
        }

        localStorage.setItem('fleetAppOptions', JSON.stringify(fleetAppOptions));

        // Retrieve value...
        let first = storage.get('foo'); // undefined :(
        let second = storage.get('foo', StorageTranscoders.STRING); // 'bar' :)

        let third = storage.get('fleetAppOptions', StorageTranscoders.JSON); // 'bar' :)

  
    }


    getFleetAppOptions(): FleetAppOptions {
        let fleetAppOptions: FleetAppOptions = this.storage.get('fleetAppOptions', StorageTranscoders.JSON);

        if (typeof(fleetAppOptions) === 'undefined') {
            fleetAppOptions = {
                userName: "",
                isAuthorized: false,
                customerId: 0,
                customerName: ""
            };
        }
        
        return fleetAppOptions;
    }


    API_PATH = 'http://localhost:52467/api/';
    ORG_LEVEL_DEFINITION_DEVEXPRESS_ENDPOINT = this.API_PATH + 'DxDatasource/OrgLevelDefinitions';
    CARD_DEVEXPRESS_ENDPOINT = this.API_PATH + 'DxDatasource/Cards';
    DRIVERS_DEVEXPRESS_ENDPOINT = this.API_PATH + 'DxDatasource/Drivers';
    VEHICLES_DEVEXPRESS_ENDPOINT = this.API_PATH + 'DxDatasource/Vehicles';
    CUSTOMERS_DEVEXPRESS_ENDPOINT = this.API_PATH + 'DxDatasource/Customers';
    BUSINESS_HOURS_DEVEXPRESS_ENDPOINT = this.API_PATH + 'DxDatasource/BusinessHours';

    getDevExpressDriverDatasource(optionalParameters?: KeyValuePair[]) {
        return this.getDevExpressDataSource(this.DRIVERS_DEVEXPRESS_ENDPOINT, optionalParameters);
    }

    getDevExpressCardDatasource(optionalParameters?: KeyValuePair[]) {
        return this.getDevExpressDataSource(this.CARD_DEVEXPRESS_ENDPOINT, optionalParameters);
    }

    getDevExpressVehicleDatasource(optionalParameters?: KeyValuePair[]) {
        return this.getDevExpressDataSource(this.VEHICLES_DEVEXPRESS_ENDPOINT, optionalParameters);
    }

    getDevExpressOrgLevelDefinitionDatasource(optionalParameters?: KeyValuePair[]) {
        return this.getDevExpressDataSource(this.ORG_LEVEL_DEFINITION_DEVEXPRESS_ENDPOINT, optionalParameters);
    }

    getDevExpressCustomerDatasource(optionalParameters?: KeyValuePair[]) {
        return this.getDevExpressDataSource(this.CUSTOMERS_DEVEXPRESS_ENDPOINT, optionalParameters);
    }

    getDevExpressBusinessHoursDatasource(optionalParameters?: KeyValuePair[]) {
        return this.getDevExpressDataSource(this.BUSINESS_HOURS_DEVEXPRESS_ENDPOINT, optionalParameters);
    }

    getDevExpressDataSource(apiPath: string, optionalParameters?: KeyValuePair[]) {

        let isNotEmpty = function (value: any): boolean {
            return value !== undefined && value !== null && value !== '';
        }

        return new DataSource({
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
                    if (i in loadOptions && isNotEmpty(loadOptions[i]))
                        params = params.set(i, JSON.stringify(loadOptions[i]));
                });

                if (typeof(optionalParameters) !== 'undefined') {
                    optionalParameters.forEach(i => {
                        params = params.append(i.key, i.value);
                    })
                }

                // console.log('params:');
                // console.log(params.set("baid", "1234"));
                // params = params.append("baid", "1234");
                // console.log(params);
                return this.http.get(apiPath, { params: params })
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
            },

            update: (key, values) => {
                let headers = new HttpHeaders().set('Content-Type', 'application/json')
                console.log('key');
                console.log(key);
                console.log('values');
                console.log(values);
                return this.http.put(apiPath + key, JSON.stringify(JSON.stringify(values)), { headers: headers }).toPromise()
                    .then((result: any) => {
                        return {
                            data: 0
                        };
                    }
                    )
            }

        });
    }

    getDevExpressGridFieldNames(grid: DxDataGridComponent) {
        return grid.columns.map(x => x['dataField']);
    }
}