using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Prog 1A
// D3051
// 9/25/17
// CIS 200-76
// TwoDayAirPackage is derived from package and allows the user to choose if they want early or saver two day delivery.
// this class also contains a CalcCost method that returns the shipping cost based on the user's choice
namespace Prog0
{
    class TwoDayAirPackage : Package
    {
        private const decimal specNumber = .25M; // magic number used in base cost equation
        private decimal baseCost;// base cost for shipping
        private const decimal saver = .90M; //
        public enum Delivery { Early, Saver };// two choices for Two day air package 

        public TwoDayAirPackage(Address originAddress, Address destAddress, Package length,
            Package width, Package height, Package weight, enum Delivery)
    
        public enum Delivery
        {
            //Precondition: None
            //Postcondition: get is returned
            get;
            // Precondition: None
            // Postcondition: delivery is returned with specified value
            set;
        }
        // Precondition: None
        // Postcondition: shipping cost is returned with specified value
        public override decimal CalcCost()
        {
            if (Delivery = Delivery.Early)
                baseCost = specNumber * (Length + Width + Height) + specNumber * Weight;
            else 
                baseCost* (specNumber *(Length + Width + Height) + specNumber * Weight)*saver;
            return baseCost;
        }
        //Precondition: None
        // Postcondition: String is returned with TwoDayAirPackage's data values
        public override string ToString()
        {
            return CalcCost + base.ToString();
        }
    }
}
