using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TollCalculator.Models
{
    public class Vehicle
    {
        // toll charges in euro
        const double CarTollCharge = 2.00;
        const double PSVTollCharge = 2.00;
        const double BusTollCharge = 2.80;
        const double GoodsTollCharge = 4.10;

        // discount for having an electronic tag
        const double DiscountPercentage = 0.20;                // 20%


        // 4 different vehicle types
        public static String[] VehicleTypes
        {
            get
            {
                return new String[] { "Car", "PSV", "Bus", "Goods" };
            }
        }

        [Required]
        [Display(Name = "Vehicle Type")]
        public String VehicleType { get; set; }

        [Required]
        [Display(Name = "Electronic Tag")]

        public bool HasETag { get; set; }
        [Display(Name = "Toll Charge")]
        public double Charge
        {
            get                             // calculate the toll charge
            {
                double toll = 0;
                if (VehicleType == "Car")
                {
                    toll = CarTollCharge;
                }
                else if (VehicleType == "PSV")
                {
                    toll = PSVTollCharge;
                }
                else if (VehicleType == "Bus")
                {
                    toll = BusTollCharge;
                }
                else if (VehicleType == "Goods")
                {
                    toll = GoodsTollCharge;
                }

                if (HasETag)                // apply discount
                {
                    toll *= 1 - DiscountPercentage;
                }
                return toll;
            }
        }
    }
}
