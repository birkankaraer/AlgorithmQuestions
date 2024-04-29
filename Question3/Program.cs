using System;

class Program
{
    static void Main()
    {
        //Three brothers A, B, C want to travel 300 km. They have a bike which goes in uniform velocity 60 km/h which can carry 2 members in a time.
        //Each brother can walk 15 km/h how they can reach the final point with minimum time?
        double Vw = 15; 
        double Vb = 60; 

        double totalDistance = 300;

        double totalTime = CalculateTotalTime(Vw, Vb, totalDistance);

        Console.WriteLine($"Minimum time for the three brothers to reach the destination: {totalTime} hours");
    }

    static double CalculateTotalTime(double Vw, double Vb, double totalDistance)
    {
        double T3 = totalDistance * (3 * Vb + Vw) / (195 * Vb);

        double T1 = T3 * (Vb + Vw) / (3 * Vb + Vw);

        double T2 = T3 * 2 * Vb / (3 * Vb + Vw);

        double totalTime = T1 + T2 + T3;

        return totalTime;
    }
}
