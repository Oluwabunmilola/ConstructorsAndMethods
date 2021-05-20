using System;

public class Triangle
{
       

    public void AreaOfTriangle(double _base,double _height) //You can have more than one methods in a class
    {

        var formula=0.5*_base*_height;
        Console.WriteLine("The area is "+ formula) ;
    }
  public void PeriOfTriangle(double triBase,double triHeight, double triLength) //You can have more than one methods in a class
    {
        var formula1=triBase+triHeight+triLength;
        Console.WriteLine("The perimeter is "+ formula1) ;
    }


}