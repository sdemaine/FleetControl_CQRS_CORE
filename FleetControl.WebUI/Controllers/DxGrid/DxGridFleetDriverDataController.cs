using DevExtreme.AspNet.Data;
using FleetControl.Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Northwind.WebUI.Controllers.DxGrid
{
    [Route("api/dxgrid/driver")]
    public class DxGridDriverDataController : Controller
    {
        //public DxGridDriverDataController(IRepositoryWrapper repository)
        //{
        //    _repository = repository;
        //}

        //[HttpGet]
        //public object Drivers(DataSourceLoadOptions loadOptions)
        //{
        //    return DataSourceLoader.Load(_repository.Driver.FindByCondition(x => x.CustomerId == 101).AsQueryable(), loadOptions);
        //}

        //[HttpPost]
        //[Route("CreateDriver")]
        //public IActionResult CreateDriver(string values)
        //{
        //    try
        //    {
        //        var newDriver = new Driver();
        //        JsonConvert.PopulateObject(values, newDriver);


        //        //if (!TryValidateModel(newDriver))
        //        //    //return BadRequest(ModelState.GetFullErrorMessage());
        //        //    return BadRequest();
        //        //newDriver.CustomerId = 101;
        //        //_repository.Driver.Create(newDriver);
        //        //_repository.Save();
        //        return Ok(newDriver);
        //    }
        //    catch (Exception ex)
        //    {

        //        return BadRequest(ex.Message);
        //    }

        //}

        //[HttpPut]
        //[Route("UpdateDriver")]
        //public IActionResult UpdateDriver(int key, string values)
        //{
        //    var driver = _repository.Driver.FindByCondition(x => x.Id == key).FirstOrDefault();
        //    JsonConvert.PopulateObject(values, driver);

        //    if (!TryValidateModel(driver))
        //        //return BadRequest(ModelState.GetFullErrorMessage());
        //        return BadRequest();

        //    _repository.Save();

        //    return Ok(driver);
        //}

        //[HttpDelete]
        //[Route("DeleteDriver")]
        //public void DeleteDriver(int key)
        //{
        //    try
        //    {
        //        var driverToDelete = _repository.Driver.FindByCondition(x => x.Id == key).FirstOrDefault();
        //        if (driverToDelete != null)
        //        {
        //            _repository.Driver.Delete(driverToDelete);
        //            _repository.Save();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        var exceptionMessage = ex.Message;
        //    }

        //}

        //// additional actions

        //[HttpGet]
        //public object OrderDetails(int orderID, DataSourceLoadOptions loadOptions)
        //{
        //    return DataSourceLoader.Load(
        //        from i in _nwind.Order_Details
        //        where i.OrderID == orderID
        //        select new
        //        {
        //            Product = i.Product.ProductName,
        //            Price = i.UnitPrice,
        //            Quantity = i.Quantity,
        //            Sum = i.UnitPrice * i.Quantity
        //        },
        //        loadOptions
        //    );
        //}

        //[HttpGet]
        //public object ShippersLookup(DataSourceLoadOptions loadOptions)
        //{
        //    var lookup = from i in _nwind.Shippers
        //                 orderby i.CompanyName
        //                 select new
        //                 {
        //                     Value = i.ShipperID,
        //                     Text = i.CompanyName
        //                 };

        //    return DataSourceLoader.Load(lookup, loadOptions);
        //}

        //[HttpGet]
        //public object CustomersLookup(DataSourceLoadOptions loadOptions)
        //{
        //    var lookup = from i in _nwind.Customers
        //                 let text = i.CompanyName + " (" + i.Country + ")"
        //                 orderby i.CompanyName
        //                 select new
        //                 {
        //                     Value = i.CustomerID,
        //                     Text = text
        //                 };

        //    return DataSourceLoader.Load(lookup, loadOptions);
        //}
    }
}
