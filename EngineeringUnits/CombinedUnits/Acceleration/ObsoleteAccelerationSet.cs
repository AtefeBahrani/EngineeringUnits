﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Acceleration
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Acceleration FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new Acceleration(value, AccelerationUnit.SI);
        //}

        /// <summary>
        ///     Get Acceleration from CentimetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentimetersPerSecondSquared->FromCentimeterPerSecondSquared")]
        public static Acceleration FromCentimetersPerSecondSquared(double centimeterspersecondsquared)
        {
            double value = (double)centimeterspersecondsquared;
            return new Acceleration(value, AccelerationUnit.CentimeterPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from DecimetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecimetersPerSecondSquared->FromDecimeterPerSecondSquared")]
        public static Acceleration FromDecimetersPerSecondSquared(double decimeterspersecondsquared)
        {
            double value = (double)decimeterspersecondsquared;
            return new Acceleration(value, AccelerationUnit.DecimeterPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from FeetPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromFeetPerSecondSquared->FromFootPerSecondSquared")]
        public static Acceleration FromFeetPerSecondSquared(double feetpersecondsquared)
        {
            double value = (double)feetpersecondsquared;
            return new Acceleration(value, AccelerationUnit.FootPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from InchesPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromInchesPerSecondSquared->FromInchPerSecondSquared")]
        public static Acceleration FromInchesPerSecondSquared(double inchespersecondsquared)
        {
            double value = (double)inchespersecondsquared;
            return new Acceleration(value, AccelerationUnit.InchPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from KilometersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilometersPerSecondSquared->FromKilometerPerSecondSquared")]
        public static Acceleration FromKilometersPerSecondSquared(double kilometerspersecondsquared)
        {
            double value = (double)kilometerspersecondsquared;
            return new Acceleration(value, AccelerationUnit.KilometerPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from KnotsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKnotsPerHour->FromKnotPerHour")]
        public static Acceleration FromKnotsPerHour(double knotsperhour)
        {
            double value = (double)knotsperhour;
            return new Acceleration(value, AccelerationUnit.KnotPerHour);
        }
        /// <summary>
        ///     Get Acceleration from KnotsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKnotsPerMinute->FromKnotPerMinute")]
        public static Acceleration FromKnotsPerMinute(double knotsperminute)
        {
            double value = (double)knotsperminute;
            return new Acceleration(value, AccelerationUnit.KnotPerMinute);
        }
        /// <summary>
        ///     Get Acceleration from KnotsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKnotsPerSecond->FromKnotPerSecond")]
        public static Acceleration FromKnotsPerSecond(double knotspersecond)
        {
            double value = (double)knotspersecond;
            return new Acceleration(value, AccelerationUnit.KnotPerSecond);
        }
        /// <summary>
        ///     Get Acceleration from MetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMetersPerSecondSquared->FromMeterPerSecondSquared")]
        public static Acceleration FromMetersPerSecondSquared(double meterspersecondsquared)
        {
            double value = (double)meterspersecondsquared;
            return new Acceleration(value, AccelerationUnit.MeterPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from MicrometersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrometersPerSecondSquared->FromMicrometerPerSecondSquared")]
        public static Acceleration FromMicrometersPerSecondSquared(double micrometerspersecondsquared)
        {
            double value = (double)micrometerspersecondsquared;
            return new Acceleration(value, AccelerationUnit.MicrometerPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from MillimetersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillimetersPerSecondSquared->FromMillimeterPerSecondSquared")]
        public static Acceleration FromMillimetersPerSecondSquared(double millimeterspersecondsquared)
        {
            double value = (double)millimeterspersecondsquared;
            return new Acceleration(value, AccelerationUnit.MillimeterPerSecondSquared);
        }
        /// <summary>
        ///     Get Acceleration from MillistandardGravity.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Acceleration FromMillistandardGravity(double millistandardgravity)
        //{
        //    double value = (double)millistandardgravity;
        //    return new Acceleration(value, AccelerationUnit.MillistandardGravity);
        //}
        /// <summary>
        ///     Get Acceleration from NanometersPerSecondSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanometersPerSecondSquared->FromNanometerPerSecondSquared")]
        public static Acceleration FromNanometersPerSecondSquared(double nanometerspersecondsquared)
        {
            double value = (double)nanometerspersecondsquared;
            return new Acceleration(value, AccelerationUnit.NanometerPerSecondSquared);
        }

        /// <summary>
        ///     Get Acceleration from StandardGravity.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Acceleration FromStandardGravity(double standardgravity)
        //{
        //    double value = (double)standardgravity;
        //    return new Acceleration(value, AccelerationUnit.StandardGravity);
        //}




    }
}
