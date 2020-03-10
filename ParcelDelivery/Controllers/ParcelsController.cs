using Microsoft.AspNetCore.Mvc;
using ParcelDelivery.Models;
using System;

namespace ParcelDelivery.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // [HttpGet("/ship")]
    // public ActionResult Ship()
    // {
    //   return View();
    // }

    [HttpPost("/ship")]
    public ActionResult Ship(string weight, string height, string boxlength, string width)
    {
      double doubleHeight = double.Parse(height);
      double doubleWidth = double.Parse(width);
      double doubleLength = double.Parse(boxlength);
      double doubleWeight = double.Parse(weight);
      Parcel newParcel = new Parcel(doubleHeight, doubleWidth, doubleLength, doubleWeight);
      newParcel.CostToShip();
      return View(newParcel);
    }
  }
}
