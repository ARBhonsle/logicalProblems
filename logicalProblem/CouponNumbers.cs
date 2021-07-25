using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class CouponNumbers
    {
        Hashtable coupons = new Hashtable();
        Random random = new Random();
        int totalCoupons,couponValue,count;
        public CouponNumbers(int number)
        {
            this.totalCoupons = number;
        }
        public void DistinctCoupon()
        {
            Console.WriteLine("Number of random numbers generated to get " + totalCoupons + " Distinct Coupons: ");
            for(count=0;coupons.Count<totalCoupons;count++)
            {
                couponValue = random.Next(0,int.MaxValue);
                if (!coupons.ContainsValue(couponValue))
                {
                    coupons.Add(count, couponValue);
                }

            }
            Console.WriteLine(count);
        }
    }
}
