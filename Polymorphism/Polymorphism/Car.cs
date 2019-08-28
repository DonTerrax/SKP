using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }


        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum,string Owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = Owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}",carIDInfo.IDNum,carIDInfo.Owner);
        }

        public Car() { }

        public Car(int hP,string color)
        {
            this.HP = hP;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HorsePower = {0}, Color = {1}",HP,Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car was repaired");
        }
    }
}
