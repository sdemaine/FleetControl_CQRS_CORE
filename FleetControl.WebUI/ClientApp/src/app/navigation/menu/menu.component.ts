
import { NgModule, Component, enableProdMode } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { DxMenuModule, DxSelectBoxModule, DxCheckBoxModule } from 'devextreme-angular';
import { Router } from '@angular/router';
import { FleetService } from 'app/shared/fleet.service';
import { FleetAppOptions } from 'app/shared/fleet-app-options.model';

// import { Product, Service } from './app.service';

if (!/localhost/.test(document.location.host)) {
  enableProdMode();
}

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styles: []
})

export class MenuComponent {
  showSubmenuModes: any;
  showFirstSubmenuModes: any;
  currentProduct: {};
  customerName: string;
  fleetAppOptions: FleetAppOptions;

  constructor(private router: Router, fleetSvc: FleetService) {
    this.fleetAppOptions = fleetSvc.getFleetAppOptions();
    this.customerName = this.fleetAppOptions.customerName;
  }
  itemClick(evt: any) {
    console.log(evt);
    console.log(evt.itemData.link);
    console.log(this.router);
    console.log(typeof (evt.itemData.link));

    if (typeof (evt.itemData.link) !== 'undefined') {
      this.router.navigate([evt.itemData.link]);
    }
  }

  fleetMenuItems = [
    {
      id: "1",
      name: "Customer",
      items: [
        {
          id: "1_1",
          name: "Customer Records",
          link: '/customer/customer-records'
        },
        {
          id: "1_2",
          name: "Card Records",
          link: '/customer/card-records'
        },
        {
          id: "1_3",
          name: "Vehicle Records",
          link: '/customer/vehicle-records'
        },
        {
          id: "1_4",
          name: "Driver Records",
          link: '/customer/driver-records'
        },
        {
          id: "1_5",
          name: "Customer Admin",
          items: [
            {
              id: "1_1_1",
              name: "Business Hours",
              link: '/customer/customer-admin/business-hours'
            },
            {
              id: "1_1_2",
              name: "Departments",
              link: '/customer/customer-admin/departments'
            }
          ]
        }
      ]
    },
    {
      id: "2",
      name: "Reporting",
      items: [
        {
          id: "2_1",
          name: "Transaction Detail",
          link: '/reporting/transaction-details'
        },
        {
          id: "2_2",
          name: "Transaction Error Log",
          link: '/reporting/transaction-error-log'
        },
        {
          id: "2_3",
          name: "Manual Transaction Entry",
          link: '/reporting/manual-transaction-entry'
        },
        {
          id: "2_4",
          name: "Fuel Management Report",
          link: '/reporting/fuel-management-report'
        },
        {
          id: "2_5",
          name: "Transaction Exception Report",
          link: '/reporting/transaction-exception-report'
        },
        {
          id: "2_6",
          name: "Card Report",
          link: '/reporting/card-report'
        },
        {
          id: "2_7",
          name: "Vehicle Report",
          link: '/reporting/vehicle-report'
        },
        {
          id: "2_8",
          name: "Driver Report",
          link: '/reporting/driver-report'
        },
        {
          id: "2_9",
          name: "Transaction Send Errors",
          link: '/reporting/transaction-send-errors'
        },
      ]
    },
    {
      id: "3",
      name: "Data Export",
      items: [
        {
          id: "3_1",
          name: "Fleet Export",
          link: '/data-export/fleet-export'
        }
      ]
    },
    {
      id: "4",
      name: "Reference Data",
      items: [
        {
          id: "4_1",
          name: "Card Shipment Addresses",
          link: "/reference-data/card-shipment-addresses"
        },
        {
          id: "4_2",
          name: "Locations",
          link: "/reference-data/locations"
        },
        {
          id: "4_3",
          name: "Customer Card Types",
          link: "/reference-data/customer-card-types"
        },
        {
          id: "4_4",
          name: "Customer Pricing Groups",
          link: "/reference-data/customer-pricing-groups"
        },
        {
          id: "4_5",
          name: "Location Pricing Groups",
          link: "/reference-data/location-pricing-groups"
        },
        {
          id: "4_6",
          name: "Product Codes",
          link: "/reference-data/product-codes"
        },
        {
          id: "4_7",
          name: "Purchase Orders",
          link: "/reference-data/purchase-orders"
        },
        {
          id: "4_8",
          name: "Retail Adders",
          link: "/reference-data/retail-adders"
        },
      ]
    },
    {
      id: "5",
      name: "Admin",
      items: [
        {
          id: "5_1",
          name: "Security",
          link: "/admin/security"
        },
        {
          id: "5_2",
          name: "Account Maintance",
          items: [
            {
              id: "5_2_1",
              name: "DAM Card Maintenance",
              link: "/admin/account-maintenance/dam-card-maintenance"
            },
            {
              id: "5_2_2",
              name: "DAM Vehicle Maintenance",
              link: "/admin/account-maintenance/dam-vehicle-maintenance"
            },
            {
              id: "5_2_3",
              name: "DAM Driver Maintenance",
              link: "/admin/account-maintenance/dam-driver-maintenance"
            }
          ]
        },
        {
          id: "5_3",
          name: "Customer Card Category",
          link: "/admin/customer-card-categories"
        },
      ]
    }
  ]


  products: Product[] = [{
    id: "1",
    name: "Video Players",
    items: [{
      id: "1_1",
      name: "HD Video Player",
      price: 220,
      icon: "images/products/1.png"
    }, {
      id: "1_2",
      name: "SuperHD Video Player",
      icon: "images/products/2.png",
      price: 270
    }]
  }, {
    id: "2",
    name: "Televisions",
    items: [{
      id: "2_1",
      name: "SuperLCD 42",
      icon: "images/products/7.png",
      price: 1200
    }, {
      id: "2_2",
      name: "SuperLED 42",
      icon: "images/products/5.png",
      price: 1450
    }, {
      id: "2_3",
      name: "SuperLED 50",
      icon: "images/products/4.png",
      price: 1600
    }, {
      id: "2_4",
      name: "SuperLCD 55 (Not available)",
      icon: "images/products/6.png",
      price: 1350,
      disabled: true
    }, {
      id: "2_5",
      name: "SuperLCD 70",
      icon: "images/products/9.png",
      price: 4000
    }]
  }, {
    id: "3",
    name: "Monitors",
    items: [{
      id: "3_1",
      name: "19\"",
      items: [{
        id: "3_1_1",
        name: "DesktopLCD 19",
        icon: "images/products/10.png",
        price: 160
      }]
    }, {
      id: "3_2",
      name: "21\"",
      items: [{
        id: "3_2_1",
        name: "DesktopLCD 21",
        icon: "images/products/12.png",
        price: 170
      }, {
        id: "3_2_2",
        name: "DesktopLED 21",
        icon: "images/products/13.png",
        price: 175
      }]
    }]
  }, {
    id: "4",
    name: "Projectors",
    items: [{
      id: "4_1",
      name: "Projector Plus",
      icon: "images/products/14.png",
      price: 550
    }, {
      id: "4_2",
      name: "Projector PlusHD",
      icon: "images/products/15.png",
      price: 750
    }]
  }];
}

export class Product {
  id: string;
  name: string;
  icon?: string;
  price?: number;
  disabled?: boolean;
  items?: Product[];
}