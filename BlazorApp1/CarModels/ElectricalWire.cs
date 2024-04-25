using System;
namespace BlazorApp1.CarModels
{
    public class ElectricalWiring
    {
        // Properties
        public string WireType { get; set; }
        public double WireDiameterInInches { get; set; }
        public double LengthInFeet { get; set; }
        public double ResistanceInOhmsPerFoot { get; set; }

        // Constructor
        public ElectricalWiring(string wireType, double wireDiameterInInches, double lengthInFeet, double resistanceInOhmsPerFoot)
        {
            WireType = wireType;
            WireDiameterInInches = wireDiameterInInches;
            LengthInFeet = lengthInFeet;
            ResistanceInOhmsPerFoot = resistanceInOhmsPerFoot;
        }

        // Methods
        public double CalculateResistance()
        {
            // Calculate the total resistance of the wire
            double totalResistance = LengthInFeet * ResistanceInOhmsPerFoot;
            return totalResistance;
        }

        public double CalculateVoltageDrop(double currentInAmps)
        {
            // Calculate the voltage drop across the wire due to current flow
            double voltageDrop = currentInAmps * CalculateResistance();
            return voltageDrop;
        }
    }
}

// Example usage:
// ElectricalWiring wire = new ElectricalWiring("Copper", 0.01, 100, 0.001);
// double totalResistance = wire.CalculateResistance();
// double voltageDrop = wire.CalculateVoltageDrop(5);
