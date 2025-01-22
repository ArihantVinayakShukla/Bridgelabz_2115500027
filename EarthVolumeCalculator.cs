using System;
class EarthVolumeCalculator {
    static void Main(string[] args) {
        // Create constants for Earth's radius in kilometers and conversion factor
        const double EARTH_RADIUS_KM = 6378.0;
        const double KM_TO_MILES = 0.621371;

        // Calculate Earth's volume in cubic kilometers
        double volumeKm = CalculateVolumeKm(EARTH_RADIUS_KM);

        // Calculate Earth's volume in cubic miles
        double volumeMiles = CalculateVolumeMiles(EARTH_RADIUS_KM * KM_TO_MILES);

        // Print the volume in both cubic kilometers and cubic miles
        Console.WriteLine(string.Format("The volume of earth in cubic kilometers is {0:E2} and cubic miles is {1:E2}", 
                                volumeKm, volumeMiles));
    }

    static double CalculateVolumeKm(double radius) {
        // Calculate volume using sphere formula: (4/3) * π * r³
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    static double CalculateVolumeMiles(double radiusMiles) {
        // Calculate volume using sphere formula: (4/3) * π * r³
        return (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);
    }
}