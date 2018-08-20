using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciatingValue
{
    class DepreciatingValueTest
    {
        static void Main(string[] args)
        {
            DepreciatingValue asset1 = new DepreciatingValue(5000000);
            DepreciatingValue asset2 = new DepreciatingValue(6000000);
            DepreciatingValue asset3 = new DepreciatingValue(7000000);

            DepreciatingValue.AnnualDepreciationValue = 10;

            asset1.CalculateAnnualDepreciation();
            Console.WriteLine($"{asset1.ValueOfAsset:C}");
            asset2.CalculateAnnualDepreciation();
            Console.WriteLine($"{asset2.ValueOfAsset:C}");
            asset3.CalculateAnnualDepreciation();
            Console.WriteLine($"{asset3.ValueOfAsset:C}");

            DepreciatingValue.AnnualDepreciationValue = 11;

            asset1.CalculateAnnualDepreciation();
            asset1.CalculateAnnualDepreciation();
            asset1.CalculateAnnualDepreciation();
            asset2.CalculateAnnualDepreciation();
            asset2.CalculateAnnualDepreciation();
            asset2.CalculateAnnualDepreciation();
            asset3.CalculateAnnualDepreciation();
            asset3.CalculateAnnualDepreciation();
            asset3.CalculateAnnualDepreciation();
            Console.WriteLine($"{asset1.ValueOfAsset:C}");
            Console.WriteLine($"{asset2.ValueOfAsset:C}");
            Console.WriteLine($"{asset3.ValueOfAsset:C}");

            Console.ReadLine();
        }
    }
}
