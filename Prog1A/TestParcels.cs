// Program 4
// CIS 200-01/76
// Fall 2016
// November 29, 2016
// Grading ID: C9022

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.
// It creates the original order of the Parcels and sorted by cost in ascending order.
//  Then the Parcels are sorted by destination zip code into descending order. Lastly
// parcels are sorted by parcel type in ascending order and if parcel types are the same
// then sort by cost in descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
      "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Larry Brown", "744 Blueberry Road", "Apt.34",
                "Atlanta", "GA", 30022);
            Address a6 = new Address("Bruce Wayne", "488 Batman Street", "",
                "Gotham", "NY", 00322);
            Address a7 = new Address("George Washington", "353 Apple Ave.", "",
                "Richmond", "VA", 20113);
            Address a8 = new Address("Rocky Balboa", "695 Liberty Road", "Apt. 5",
                "Philadelphia", "PA", 60554);

            Letter l1 = new Letter(a1, a3, 1.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.25M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.75M); // Test Letter 3

            GroundPackage gp1 = new GroundPackage(a6, a3, 25.4, 47.5, 23.3, 59.6); // Test Ground Package 1
            GroundPackage gp2 = new GroundPackage(a4, a7, 45.78, 33.4, 45, 60);  // Test Ground Package 2
            GroundPackage gp3 = new GroundPackage(a8, a2, 18.3, 21.4, 56, 78);  // Test Ground Package 3

            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a6, 28.2, 27.4, 34, 68.4, 4.56M); // Test Next Day Air Package 1
            NextDayAirPackage ndap2 = new NextDayAirPackage(a5, a8, 32.3, 25.3, 13.4, 87.4, 3.34M); // Test Next Day Air Package 2
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a3, 19.7, 34.6, 29.6, 65.3, 2.85M); // Test Next Day Air Package 3

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a7, a2, 48.3, 35.5, 45.3, 79.5,
                TwoDayAirPackage.Delivery.Saver); // Test Two Day Air Package 1
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a5, a4, 29.2, 37.4, 28.4, 78.3,
                TwoDayAirPackage.Delivery.Saver);  // Test Two Day Air Package 2
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a8, a6, 12.4, 24.3, 32.2, 65.8,
                TwoDayAirPackage.Delivery.Early);  // Test Two Day Air Package 3 



            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(); // sort using original order by ascending cost
            Console.WriteLine("Sorted list (original order)");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
               
            Pause();

            parcels.Sort(new DescendingDestinationAddresses()); // sort zip code in descending order
            Console.WriteLine("Sorted Zip Code in Descending order");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p.DestinationAddress.Zip);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(new SortParcelTypeAndDescendingCost()); // sort by parcel type and if same parcel type sort by cost in descending order
            Console.WriteLine("Sorted by Parcel Type and if same parcel type sort by cost in Descending Order");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p.GetType().ToString());
                Console.WriteLine(p.CalcCost());
                Console.WriteLine("====================");
            }
            Pause();
       }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
