using System;

namespace Vehicle {
    class Program {
        static void Main (string[] args) {
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

            fxs.Drive ();
            modelS.Drive ();
            mx410.Drive ();
            fifteenhundred.Drive ();

            modelS.Turn ("left");
            fifteenhundred.Turn ("right");
            fxs.Stop ();
        }
    }
}