using System;
using System.Collections.Generic;

public class Dealership 
{
    List<string> AllCars {get;set;}
    List<string> SUVs {get;set;}
    List<string> Trucks {get;set;}
    List<string> Sedans {get;set;}
    List<string> Vans {get;set;}



    public Dealership()
    {
        AllCars = new List<string>();
    }

    public string AddCar(Car c)
    {
        if(c is SUV)
        {
            SUVs.add(c);
        }
        else if (c is Van)
        {
            Vans.add(c);
        }
        else if (c is Truck)
        {
            Trucks.add(c);
        }
        else if (c is Sedan)
        {
            Sedans.add(c);
        }
        AllCars.add(c);
        return "Added " + c.Make +" "+ c.Model + " at $" + c.Price;
    }

}

public class Car
{
    public string Make {get;set;}
    public string Model {get;set;}
    public int Mileage {get;set;}
    public int Price {get;set;}
    public int Year {get;set;}
    public string Picture {get;set;}

    public Car (string make, string model, int price, int mileage, int year,
    string picture)
    {
        Make = make;
        Model = model;
        Price = price;
        Mileage = mileage;
        Year = year;
        Picture = picture;
    }
}

public class SUV:Car
{
    public SUV(string make, string model, int price, int mileage, int year,
    string picture)
        :this(make,model,price,mileage,year,picture)
    {

    }
 
}

public class Truck:Car
{
    public Truck(string make, string model, int price, int mileage, int year,
    string picture)
        :this(make,model,price,mileage,year,picture)
    {

    }
 
}

public class Sedan:Car
{
    public Sedan(string make, string model, int price, int mileage, int year,
    string picture)
        :this(make,model,price,mileage,year,picture)
    {

    }
 
}

public class Van:Car
{
    public Van(string make, string model, int price, int mileage, int year,
    string picture)
        :this(make,model,price,mileage,year,picture)
    {

    }
 
}
