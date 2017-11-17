// Program 4
// CIS 200-01/76
// Fall 2016
// November 29, 2016
// Grading ID: C9022

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        return String.Format("Origin Address:{3}{0}{3}{3}Destination Address:{3}{1}{3}Cost: {2:C}",
            OriginAddress, DestinationAddress, CalcCost(), Environment.NewLine);
    }

    // Precondition: None
    // Postcondition: When this is = p2, method returns 
    //                When this is < p2, method returns postive 1
    //                When this is > p2, method returns negative 1
    public int CompareTo(Parcel p2)
    {
        if (this == null && p2 == null) // both null?
            return 0; // Equal

        if (p2 == null) // only p2 null?
            return 1; // Actual cost is greater than null

        if (this == null) // only this is null?
            return -1; // null is less than the actual cost

        return (this.CalcCost().CompareTo(p2.CalcCost())); // return CalcCost to decide

    }
}
