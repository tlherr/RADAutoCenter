using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter
{
    class PackageFactory
    {
        string[][] standardArray =
        {
            new string[] {"Hand Wash" },
            new string[] {"Fragrance" }
        };
        string[][] deluxeArray =
        {
            new string[] {"Hand Wash", "Hand Wax"},
            new string[] {"Fragrance", "Shampoo Carpets"}
        };
        string[][] executiveArray =
        {
            new string[] {"Hand Wash", "Hand Wax", "Check Engine Fluids"},
            new string[] {"Fragrance", "Shampoo Carpets", "Interior Protection Coat (Dashboard and Console)" }
        };

        string[][] luxuryArray =
        {
            new string[] {"Hand Wash", "Hand Wax", "Check Engine Fluids", "Detail Engine Compartment", "Detail Undercarriage"},
            new string[] {"Fragrance", "Shampoo Carpets", "Shampoo Upholstery", "Interior Protection Coat (Dashboard and Console)", "Scotchguard"}
        };
        

        string[][] getPackage(string name, string fragrance, bool interior, bool exterior)
        {
            name = name.ToLower();
            switch(name)
            {
                case "standard":
                    string[][] standardArray = this.standardArray;
                    if(fragrance != null)
                    {
                        standardArray[1][0] = fragrance;
                    }

                    return standardArray;

                case "deluxe":
                    string[][] deluxeArray = this.deluxeArray;
                    if (fragrance != null)
                    {
                        deluxeArray[1][0] = fragrance;
                    }

                    return deluxeArray;

                case "executive":
                    string[][] executiveArray = this.executiveArray;
                    if (fragrance != null)
                    {
                        executiveArray[1][0] = fragrance;
                    }

                    return executiveArray;

                case "luxury":
                    string[][] luxuryArray = this.luxuryArray;
                    if (fragrance != null)
                    {
                        luxuryArray[1][0] = fragrance;
                    }

                    return luxuryArray;
            }

            return null;
        }

    }
}
