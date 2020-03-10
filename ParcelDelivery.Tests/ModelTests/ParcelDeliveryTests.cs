using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelDelivery.Models;
using System;

namespace ParcelDelivery.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void CostToShip_CalculatesCost_Price()
    {
      Parcel newParcel = new Parcel(1,1,1,1);
      newParcel.CostToShip();
      Assert.AreEqual(1.05, newParcel.Price);
    }

    [TestMethod]
    public void ParcelConstructor_CalculatesVolume_1()
    {
      Parcel newParcel = new Parcel(1,1,1,1);
      Assert.AreEqual(1, newParcel.Volume);
    }
  }
}