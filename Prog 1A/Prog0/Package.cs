using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// By: D3051
// 9/25/17
// Program 1A
// CIS 200-76
//Package is an abstract class and tracts the dimensions and weight of each package
namespace Prog0
{
    public abstract class Package : Parcel
    {// Precondition: None
     // Postcondition: Package is created with the specified values for origin address, destination address,
     // length, width, height, and weight
        public Package(Address originAddress, Address destAddress, double length,
            double width, double height, double weight)
            : base(originAddress, destAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destAddress;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }
        public Address OriginAddress
        {
            //Precondition: None
            // Postcondition: origin address is returned 
            get;
            // Precondition:  None
            // Postcondition: The origin address is set to the
            //                specified value
            set;
        }
        public Address DestinationAddress
        {
            // Precondition:  None
            // Postcondition: The destination address is returned
            get;

            // Precondition:  None
            // Postcondition: The destination address is set to the
            //                specified value
            set;
        }
        public GroundPackage Length
        {  //Precondition: None
            // Postcondition: the length is returned 
            get;
            // Precondition:  None
            // Postcondition: The length is set to the
            //                specified value
            set;
        }
        public GroundPackage Width
        {
            //Precondition: None
            // Postcondition: the width is returned 
            get;
            // Precondition:  None
            // Postcondition: The width is set to the
            //                specified value
            set;
        }
        public GroundPackage Height
        {
            //Precondition: None
            // Postcondition: the height is returned 
            get;
            // Precondition:  None
            // Postcondition: The height is set to the
            //                specified value
            set;
        }
        public GroundPackage Weight
        {
            //Precondition: None
            // Postcondition: the weight is returned 
            get;
            // Precondition:  None
            // Postcondition: The weight is set to the
            //                specified value
            set;
        }
        // Precondition:  None
        // Postcondition: A string with Package's data fields is returned
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
