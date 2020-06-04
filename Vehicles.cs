using System;

namespace Vehicle {
    public class Tesla : Vehicle {
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            Console.WriteLine ("Battery now at 100%");
        }
        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Tesla drives by you. *silence*");
        }
    }

    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            Console.WriteLine ("Battery now at 100%");
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Zero drives by you. Vroom.");
        }
    }

    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank () {
            Console.WriteLine ("Gas tank is full");
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Cessna flies by you. Zoom.");
        }
    }

    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank () {
            Console.WriteLine ("Gas tank is full");
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Ram drives by you. *loud truck noises*");
        }
    }

}