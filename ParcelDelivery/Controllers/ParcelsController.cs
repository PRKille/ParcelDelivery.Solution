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

    [HttpGet("/error")]
    public ActionResult Error(string message)
    {
      return View(message);
    }

    [HttpPost("/ship")]
    public ActionResult Ship(string weight, string height, string boxlength, string width)
    {
      try
      {
        if (String.IsNullOrWhiteSpace(weight) || String.IsNullOrWhiteSpace(height) || String.IsNullOrWhiteSpace(boxlength) || String.IsNullOrWhiteSpace(width))
        {
          throw new System.InvalidOperationException("Invalid input");
        } 
        else
        {
          double doubleHeight = double.Parse(height, System.Globalization.NumberStyles.AllowDecimalPoint);
          double doubleWidth = double.Parse(width);
          double doubleLength = double.Parse(boxlength);
          double doubleWeight = double.Parse(weight);
          Parcel newParcel = new Parcel(doubleHeight, doubleWidth, doubleLength, doubleWeight);
          newParcel.CostToShip();
          return View(newParcel);
        }
      }
      catch (Exception ex)
      {
        return View("Error", ex.Message);
      }
    }
  }
}
