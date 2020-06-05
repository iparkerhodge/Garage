using System;

namespace Vehicle {
    public class Tesla : Vehicle, IElectric {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 50;

        public void ChargeBattery () {
            CurrentChargePercentage = 100;
        }
        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Tesla drives by you. *silence*");
        }
    }

    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 50;

        public void ChargeBattery () {
            CurrentChargePercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Zero drives by you. Vroom.");
        }
    }

    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank () {
            CurrentTankPercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Cessna flies by you. Zoom.");
        }
    }

    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank () {
            CurrentTankPercentage = 100;
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} Ram drives by you. *loud truck noises*");
        }
    }

}