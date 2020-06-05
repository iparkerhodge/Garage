namespace Vehicle {
    public interface IElectric {
        int CurrentChargePercentage { get; set; }

        void ChargeBattery ();
    }

    public interface IGas {
        int CurrentTankPercentage { get; set; }

        void RefuelTank ();
    }
}