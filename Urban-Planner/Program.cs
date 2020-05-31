using System;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building atAndT = new Building("333 commerce st", new DateTime(1994));
            Building oakLandMansion = new Building("900 N Maney Ave, Murfreesboro, TN 37130", new DateTime(1889));
            Building rockCastle = new Building("139 Rockcastle Ln, Hendersonville, TN 37075", new DateTime(1876));
            Building calvaryEpiscopalChurch = new Building("102 N 2nd St, Memphis, TN 38103", new DateTime(1921));

            City nashville = new City("nashville", "tennessee", 1806);
            City murfreesboro = new City("Murfreesboro", "tennessee", 1770);
            City hendersonville = new City("Hendersonville", "tennessee", 1784);
            City memphis = new City("Memphis", "tennessee", 1819);

            nashville.AddBuilding(atAndT);
            murfreesboro.AddBuilding(oakLandMansion);
            hendersonville.AddBuilding(rockCastle);
            memphis.AddBuilding(calvaryEpiscopalChurch);
            atAndT.Width = 40;
            atAndT.Depth = 50;
            atAndT.Stories = 20;
            System.Console.WriteLine("AT&T Was built in {0}",atAndT.DateContructed());
            System.Console.WriteLine("AT&T volume {0} cubic meter",atAndT.Volume);
            atAndT.PrintBuilding();
        }
    }
}
