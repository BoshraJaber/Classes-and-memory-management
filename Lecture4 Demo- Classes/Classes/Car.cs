using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture4_Demo__Classes.Classes
{
    public class Car
    {

        
        public string Make { get; set; }
        public int Speed { get; set; }
        public bool IsDriving { get; set; }
        private string color;
        public string Color 
        {
           get { return color; }
            set
            {
                if(value == "brown")
                {
                    color = "red";
                } else
                {
                    color = value;
                }
            }
        }
        public Engine engine { get; set; }
        //constrcutors
        public Car()
        {

        }
        public Car(string make, string color, int cyl)
        {
            Make = make;
            Color = color;
            engine = new Engine(cyl);
        }
        // Methods:
        public void Drive()
        {
            IsDriving = true;
        }
        public void Stop()
        {
            IsDriving = false;
        }

        





  
    }
}
