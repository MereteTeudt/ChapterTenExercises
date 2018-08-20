using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciatingValue
{
    class DepreciatingValue
    {
        public int ValueOfAsset { get; set; }
        public static int AnnualDepreciationValue { get; set; }

        public DepreciatingValue(int assetValue)
        {
            ValueOfAsset = assetValue;
        }
        public void CalculateAnnualDepreciation()
        {
            int percent = ValueOfAsset / 100 * AnnualDepreciationValue;
            ValueOfAsset -= percent;
        }
    }
}
