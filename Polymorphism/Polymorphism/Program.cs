using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            // A car can be a Bmw,Audi or Porche etc.
            // Polymorphism at work #1 an Audi, Bmw, Porche
            // can all be used whereever a car is expected. No cast is required
            // because an implicit conversion exists from a dreived class to its base class.
            var cars = new List<Car>
            {
                new Audi(420,"red","RS3"),
                new Bmw(450,"blue","M3")
            };


            // Polymopishm at work#2 The virtual method repair is invoked on each of the derived classes, not the base class.
            foreach (var car in cars)
            {
                car.Repair();
                
            }

            Car BmwM4 = new Bmw(500,"Black","M4");
            Car AudiRS6 = new Audi(550,"Nardo Gray","RS6");
            BmwM4.ShowDetails();
            AudiRS6.ShowDetails();

            BmwM4.SetCarIDInfo(1234,"Mike");
            AudiRS6.SetCarIDInfo(12345,"Morten");
            BmwM4.GetCarIDInfo();
            AudiRS6.GetCarIDInfo();

            Bmw BmwM5 = new Bmw(600,"Red","M5");
            BmwM5.ShowDetails();

            M3 myM3 = new M3(350,"red","M3 super");
            myM3.Repair();

            

        }
    }
}
