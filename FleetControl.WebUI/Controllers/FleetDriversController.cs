using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using FleetControl.Application.Interfaces;
using FleetControl.Application.Queries;
using FleetControl.Application.Queries.Customers.GetFleetCustomer;
using FleetControl.Application.Queries.Drivers;
using FleetControl.Application.Queries.Drivers.GetFleetDriverList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    [Route("api/FleetDrivers")]
    public class FleetDriversController : BaseController
    {
        
    }
}