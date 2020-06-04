using System;

namespace Vehicle {
    public class Vehicle {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive () {
            Console.WriteLine ("Vrooom!");
        }

        public void Turn (string direction) {
            Console.WriteLine ($"Made a {direction} turn.");
        }

        public void Stop () {
            Console.WriteLine ("The vehicle came to a stop");
        }
    }
}