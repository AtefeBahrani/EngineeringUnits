﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LapseRate
    {
        /// <summary>
        ///     Get LapseRate from DegreesCelciusPerKilometer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LapseRate FromDegreesCelciusPerKilometer(double degreescelciusperkilometer)
        {
            double value = (double)degreescelciusperkilometer;
            return new LapseRate(value, LapseRateUnit.DegreeCelsiusPerKilometer);
        }

    }
}
