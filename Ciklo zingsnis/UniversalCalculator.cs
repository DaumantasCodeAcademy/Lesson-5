using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklo_zingsnis
{
    internal class UniversalCalculator
    {
        private int earthRadiusInKm = 6371;
        private decimal pi = 3.14m;

        public decimal GetEarthArea()
        {
            return 4 * pi * earthRadiusInKm * earthRadiusInKm;
        }
    }
}
