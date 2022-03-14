using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_globalus_kintamieji
{
    internal class DataStorage
    {
        private List<List<decimal>> newData;
        private decimal[,] data;
        public int currentElementsCount;
        private int maxElementsCount = 20;

        public DataStorage()
        {
            currentElementsCount = 0;
            data = new decimal[maxElementsCount, 2];
        }

        public void Add(decimal height, decimal weight)
        {
            data[currentElementsCount, 0] = height;
            data[currentElementsCount, 1] = weight;
            currentElementsCount++;
        }

        public decimal[,] GetStorageData()
        {
            return data;
        }
    }
}
