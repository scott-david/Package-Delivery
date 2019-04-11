using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Prog 1A
// D3051
//9/25/19
//CIS 200-76
//This class, Air Package, is an abstract class derived from Package. It has two methods within it 
// showing us if the package is heavy, with the IsHeavy method and if the package is large with the IsLarge method.
namespace Prog0
{
    public abstract class AirPackage : Package
    {
        private const int HEAVY_WEIGHT = 75; // weight specified that makes a package heavy
        private const int MAX_DIMENSION_SUM = 100;// total dimension in inches that makes the package large

        // Precondition: None
        // Postcondition: AirPackage is created with specified values for origin address, destination address, 
        // length, width, height, and weight
        public abstract AirPackage(Address originAddress, Address destAddress, Package length,
            Package width, Package height, Package weight)
        {

        }
        // Precondition: None
        // Postcondition: bool value, true or false is returned, based on if the weight is >= 75 lbs
        public bool IsHeavy()
        {
            if (Weight >= HEAVY_WEIGHT)
                return true;
            else
                return false;
        }
        // Precondition: None
        // Postcondition: bool value, true or false is returned, base on if the sum of the dimensions are >= 100in
        public bool IsLarge()
        {
            if (Length + Width + Weight >= MAX_DIMENSION_SUM)
                return true;
            else
                return false;
        }
        // Precondition: None
        // Postcondition: string is returned 
        public override String ToString()
        {
            string NL = Environment.NewLine;
            return "Is the package heavy? " + IsHeavy + NL + "Is the package large? "
                + IsLarge + base.ToString();
        }
    }
}
