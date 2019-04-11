using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// D3051
// 9/25/17
// CIS 200-76
// Prog 1A
// NextDayAirPackage is derived from AirPackage and contains an ExpressFee, along with a CalcCost method
// to determine the shipping costs
namespace Prog0
{   // Precondition: None
    // Postcondition: NextDayAirPackage is created with specified values for origin address, destination address, 
    // length, width, height, and weight. 
    public class NextDayAirPackage : AirPackage
    {
        private decimal Fee; // Fee for express shipping
        private const decimal dimensionValue = .40M;
        private const decimal weightValue = .30M;
        private const decimal heavyOrLarge = .25M;
        public decimal baseCost; // base cost for shipping cost

        public NextDayAirPackage(Address originAddress, Address destAddress, Package length, 
            Package width, Package height, Package weight)
        {

        }
        //Precondition: None
        //Postcondition: Fee is returned
        private decimal ExpressFee
        {//Precondition: None
         //Postcondition: Fee is returned
            get
            {
                return Fee;
            }
        }
        // Precondition: None
        // Postcondition: baseCost for shipping is returned
        public override decimal CalcCost()
        {
            if (IsHeavy || IsLarge = true)
            {
                baseCost = dimensionValue * (Length + Width + Height) +
                    weightValue * Weight + ExpressFee + heavyOrLarge * Weight;
            }
            else
            {
                baseCost = dimensionValue * (Length + Width + Height) +
                    weightValue * Weight + ExpressFee
            }
            return baseCost;
        }
        // Precondition: None
        // Postcondition: String with NextDayAirPackage's data is returned
        public override string ToString()
        {
            return CalcCost + base.ToString();
        }

    }
}
