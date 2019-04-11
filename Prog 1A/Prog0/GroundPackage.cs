using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// D3051
// 9/25/17
// program 1A
// CIS 200-76
// Ground package is a Package which contains a read-only Zone Distance 
// to get the shipping cost by using the override method CalcCost
namespace Prog0
{
    public class GroundPackage : Package
    {
        private double _length; // length of package
        private double _width;// width of package
        private double _height; // height of package 
        private double _weight; // weight of package 
        private string _origin; // origin address
        private string _destination; // desination address
        private decimal specCost = .20M; // used in Cost equation, instead of magic number
        private decimal zoneCost = .05M;// used in Cost equation, instead of magic number
        private decimal number = 1;// used in Cost equation, instead of magic number
        public decimal cost; // shipping cost, in CalcCost override method 
         
        // Precondition:  None
        // Postcondition: Groundpackage is created with specified values for origin address, dest address,
        // length, width, height, and weight
        public GroundPackage(string originAddress, string destAddress,
            double length, double width, double height, double weight)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            OriginAddress = originAddress;
            DestinationAddress = destAddress;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }
         
        public string OriginAddress
        {// Precondition:  None
         // Postcondition: origin address is returned
            get
            {
                return _origin;
            }
            // Precondition:  Cannot be null or whitespace
            // Postcondition: origin address is set to specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Origin Address is null or whitespace");
                else
                    _origin = value;
            }
        }
        public string DestinationAddress
        {// Precondition:  None
         // Postcondition: destination address is returned 
            get
            {
                return _destination;
            }
            // Precondition:  Cannot be null or whitespace
            // Postcondition: destination address is set to specified value 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Destination Address is null or whitespace");
                else
                    _destination = value;
            }
        }
        public double Length
        {// Precondition:  None
         // Postcondition: length is returned 
            get
            {
                return _length;
            }
            // Precondition:  Must be greater than 0
             // Postcondition: length is set to specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException("Length is not greater than 0");
            }
        }
        public double Width
        {// Precondition:  None
         // Postcondition: Width is returned 
            get
            {
                return _width;
            }
            // Precondition:  Must be greater than 0
            // Postcondition: Width is set to specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException("Width is not greater than 0");
            }
        }
        public double Height
        {// Precondition:  None
         // Postcondition: Height is returned
            get
            {
                return _height;
            }
            // Precondition:  Must be greater than 0
            // Postcondition: Height is set to specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException("Height is not greater than 0");
            }
        }
        public double Weight
        {// Precondition:  None
         // Postcondition: Weight is returned
            get
            {
                return _weight;
            }
            // Precondition:  Must be greater than 0
            // Postcondition: Weight is set to specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException("Weight is not greater than 0");
            }
        }
        // read-only int property
        public int ZoneDistance
        {// Precondition:  None
            // Postcondition: positive zip code value is returned
            get
            {
                const int FIRST_DIGIT = 10000; //Used to get first number of zip code
                int zipDifference; // used to calculate the difference between the two zip codes 

                zipDifference = (originzip / FIRST_DIGIT) - (destinationzip / FIRST_DIGIT);//where do i get the zips from ??
                return Math.Abs(zipDifference);
            }
        }
        // Precondition:  None
        // Postcondition: The shipping cost has been returned
        public override decimal CalcCost()
        {
        cost = specCost*(decimal)(Length + Width + Height) + zoneCost*(ZoneDistance + number)*(Weight);
            return cost;
            
        }
        // Precondition:  None
        // Postcondition: A string with GroundPackage's data fields and zone distance is returned 
        public override string ToString()
        {
            return base.ToString();
        }
    }
}



