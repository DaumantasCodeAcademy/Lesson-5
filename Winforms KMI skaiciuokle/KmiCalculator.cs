using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_KMI_skaiciuokle
{
    internal class KmiCalculator
    {
        public decimal CalculateKmi(decimal bodyMass, decimal height)
        {
            return bodyMass / (height * height);
        }
    }
}
