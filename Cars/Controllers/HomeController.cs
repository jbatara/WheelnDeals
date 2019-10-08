using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;


namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult CarDealership() 
    {   
        return View();        
    }

    [Route("/results")]
    public ActionResult SearchResult(string type, string price, string year)
    {
        Dealership d = new Dealership();
        Car car1 = new Car("Saab","9-3 Convertible",12000,50000,2011,"https://parkers-images.bauersecure.com/pagefiles/202328/cut-out/600x400/saab_93_conv03.jpg");
        d.AddCar(car1);
        SUV suv1 = new SUV("Honda","CRV",3000,120000,2008,"https://cdn.jdpower.com/Models/400x200/2008-Honda-CR-V.jpg");
        d.AddCar(suv1);
        SUV suv2 = new SUV("Honda","CRV",30000,5,2020,"https://2020hondarelease.com/wp-content/uploads/2019/04/2020-Honda-Crv-Australia-Arrival-Redesign-Interior-Changes-2.png");
        d.AddCar(suv2);
        SUV suv3 = new SUV("Tesla","Model-X",100000,10,2019,"https://wi-images.condecdn.net/image/pekOxKERYM2/crop/1620/f/tesla1.jpg");
        d.AddCar(suv3);
        Sedan sedan1 = new Sedan("Toyota","Camry LE",2500,250000,1995,"https://cdn04.carsforsale.com/3/706559/13654755/thumb/950860869.jpg");
        d.AddCar(sedan1);
        Sedan sedan2 = new Sedan("Volvo","244",1000,375000,1985,"https://cdn.bringatrailer.com/wp-content/uploads/2019/05/1985_volvo_244_1558905199bbb65d56947eIMG_0395-e1559955417902-940x590.jpg");
        d.AddCar(sedan2);
        Sedan sedan3 = new Sedan("Saturn","L Series",5000,16000,2002,"https://upload.wikimedia.org/wikipedia/commons/c/c9/00-02_Saturn_L-Series_sedan.jpg");
        d.AddCar(sedan3);
        Sedan sedan4 = new Sedan("Volkswagon","Golf",1000000000,49000,2014,"https://cimg1.ibsrv.net/ibimg/hgm/1600x900-1/100/403/2014-volkswagen-gti-concept_100403401.jpg");
        d.AddCar(sedan4);
        Truck truck1 = new Truck("Toyota","Tacoma",11380,260000,2003,"https://cdn.bringatrailer.com/wp-content/uploads/2018/03/152124801198764da20180316_122214-940x705.jpg");
        d.AddCar(truck1);
        Truck truck2 = new Truck("Chevy","S10",4812,350000,1992,"https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/1992_Chevrolet_S-10_Tahoe.jpg/280px-1992_Chevrolet_S-10_Tahoe.jpg");
        d.AddCar(truck2);
        Van van1 = new Van("Mercedes","12 Passenger Van",50000,70000,2015,"https://www.mercedes-benz-vans.ca/images/vehicles/sprinter/passenger-van-nav.png");
        d.AddCar(van1);
        List<Car> searchList = d.Search(type,price,year);

        return View(searchList);  
    }
  }
}