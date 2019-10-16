using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class WeightCalculate
    {
        public double currentWeight(int numItem,double unitWeighy)
        {
            double waitCalculate = numItem * unitWeighy;
            return waitCalculate;
        }
        public double remainWeight(double maxWeight,int numItem, double unitWeighy)
        {
            double remainCalculate =(maxWeight-(numItem * unitWeighy));
            return remainCalculate;
        }
    }
}
