using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerCostCalculate
{
    public class EmployerCost
    {
        public static double CalculateByPost(int post_id)
        {
            switch (post_id)
            {
                case 1:
                    return 50000;
            }

            return 0;
        }

    }
}
