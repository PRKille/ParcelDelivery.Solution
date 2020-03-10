using System;

namespace ParcelDelivery.Models
{
  public class Parcel
  {
    public double Height {get;set;}
    public double Width {get;set;}
    public double BoxLength {get;set;}
    public double Weight {get;set;}
    public double Volume {get;set;}
    public double Price {get;set;}
    
    public Parcel(double height, double width, double length, double weight)
    {
      Height = height;
      Width = width;
      BoxLength = length;
      Weight = weight;
      Volume = Height * Width * BoxLength;
      Price = 0;
    }

    public void CostToShip()
    {
      Price = Math.Round((Volume * Weight * 1.05), 2);
    }
  }

}