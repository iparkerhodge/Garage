using System;
using System.Collections.Generic;

namespace Vehicle {
    class Program {
        static void Main (string[] args) {
            //Inheritance Exercise
            Zero fxs = new Zero ();
            fxs.MainColor = "red";
            fxs.MaximumOccupancy = "2";
            Tesla modelS = new Tesla ();
            modelS.MainColor = "black";
            modelS.MaximumOccupancy = "4";
            Cessna mx410 = new Cessna ();
            mx410.MainColor = "yellow";
            mx410.MaximumOccupancy = "2";
            Ram fifteenhundred = new Ram ();
            fifteenhundred.MainColor = "blue";
            fifteenhundred.MaximumOccupancy = "5";

            // fxs.Drive ();
            // modelS.Drive ();
            // mx410.Drive ();
            // fifteenhundred.Drive ();

            // modelS.Turn ("left");
            // fifteenhundred.Turn ("right");
            // fxs.Stop ();

            //Interface Exercise
            List<IElectric> electricVehicles = new List<IElectric> { fxs, modelS };

            Console.WriteLine ("Electric Vehicles");
            foreach (IElectric ev in electricVehicles) {
                Console.WriteLine ($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles) {
                ev.ChargeBattery ();
            }

            foreach (IElectric ev in electricVehicles) {
                Console.WriteLine ($"{ev.CurrentChargePercentage}");
            }

            /******************************************************/

            List<IGas> gasVehicles = new List<IGas> { fifteenhundred, mx410 };

            Console.WriteLine ("Gas Vehicles");
            foreach (IGas gv in gasVehicles) {
                Console.WriteLine ($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles) {
                gv.RefuelTank ();
            }

            foreach (IGas gv in gasVehicles) {
                Console.WriteLine ($"{gv.CurrentTankPercentage}");
            }
        }
    }
}