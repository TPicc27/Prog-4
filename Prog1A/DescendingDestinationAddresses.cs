// Program 4
// CIS 200
// Fall 2016
// November 29, 2016
// Grading ID: C9022

// File: DescendingDestinationAddresses.cs
// This class compares each Destination Address zip code and puts them in 
// descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    public class DescendingDestinationAddresses: IComparer<Parcel>
    {
        // Precondition: None
        // Postcondition: Reverse zip code order, so descending
        //                When p1 = p2, method returns 0
        //                When p1 < p2, method returns positive 1
        //                When p1 > p2, method returns a negative 1
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null) // Both p1 and p2 are equal
                return 0; // equals

            if (p2 == null) // p2 is null
                return 1; // Any zip code is greater than the null

            if (p1 == null) // p1 is null
                return -1; // null is less than the zip code

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); // Reverse(descending) Zip code
        }
    }
}
