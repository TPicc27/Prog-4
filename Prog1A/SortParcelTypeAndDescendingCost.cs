// Program 4
// CIS 200
// Fall 2016
// November 29, 2016
// Grading ID: C9022

// File: SortParcelTypeAndDescendingCost.cs
// This file is to sort each parcel by parcel type in original (ascending) order.
// Then if the parcel types are equal then sort by cost in descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    // Precondition: None
    // Postcondition: Ascending Parcel type
    //                When p1 = p2, then return 0
    //                When p1 < p2, method returns postive 1
    //                When p1 > p2, method returns negative 1
    //                When p1 type is equal to p2 type
    //                then sort by cost in descending order
    class SortParcelTypeAndDescendingCost : IComparer<Parcel>
    {
        public int Compare(Parcel p1, Parcel p2)
        {

            if (p1 == null && p2 == null) // both p1 and p2 are null
                return 0; // equals

            if (p2 == null) // p2 is null
                return 1; // Any type is greater than the null

            if (p1 == null) // p1 is null
                return -1; // null is less than the parcel type

            string t1 = p1.GetType().ToString(); // p1 parcel type into t1
            string t2 = p2.GetType().ToString(); // p2 parcel type into t2

            if (t1 == t2) // t1 equals t2
                return (-1) * p1.CalcCost().CompareTo(p2.CalcCost()); // compare p1 cost to p2 cost

            return t1.CompareTo(t2); // compare t1 to t2

        }
    }
}
