﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class BitRate
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static BitRate FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new BitRate(value, BitRateUnit.SI);
        //}

        /// <summary>
        ///     Get BitRate from BitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromBitsPerSecond->FromBitPerSecond")]
        public static BitRate FromBitsPerSecond(double bitspersecond)
        {
            decimal value = (decimal)bitspersecond;
            return new BitRate(value, BitRateUnit.BitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from BytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromBytesPerSecond->FromBytePerSecond")]
        public static BitRate FromBytesPerSecond(double bytespersecond)
        {
            decimal value = (decimal)bytespersecond;
            return new BitRate(value, BitRateUnit.BytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from ExabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromExabitsPerSecond->FromExabitPerSecond")]
        public static BitRate FromExabitsPerSecond(double exabitspersecond)
        {
            decimal value = (decimal)exabitspersecond;
            return new BitRate(value, BitRateUnit.ExabitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from ExabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromExabytesPerSecond->FromExabytePerSecond")]
        public static BitRate FromExabytesPerSecond(double exabytespersecond)
        {
            decimal value = (decimal)exabytespersecond;
            return new BitRate(value, BitRateUnit.ExabytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from ExbibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromExbibitsPerSecond->FromExbibitPerSecond")]
        public static BitRate FromExbibitsPerSecond(double exbibitspersecond)
        {
            decimal value = (decimal)exbibitspersecond;
            return new BitRate(value, BitRateUnit.ExbibitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from ExbibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromExbibytesPerSecond->FromExbibytePerSecond")]
        public static BitRate FromExbibytesPerSecond(double exbibytespersecond)
        {
            decimal value = (decimal)exbibytespersecond;
            return new BitRate(value, BitRateUnit.ExbibytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from GibibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGibibitsPerSecond->FromGibibitPerSecond")]
        public static BitRate FromGibibitsPerSecond(double gibibitspersecond)
        {
            decimal value = (decimal)gibibitspersecond;
            return new BitRate(value, BitRateUnit.GibibitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from GibibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGibibytesPerSecond->FromGibibytePerSecond")]
        public static BitRate FromGibibytesPerSecond(double gibibytespersecond)
        {
            decimal value = (decimal)gibibytespersecond;
            return new BitRate(value, BitRateUnit.GibibytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from GigabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGigabitsPerSecond->FromGigabitPerSecond")]
        public static BitRate FromGigabitsPerSecond(double gigabitspersecond)
        {
            decimal value = (decimal)gigabitspersecond;
            return new BitRate(value, BitRateUnit.GigabitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from GigabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGigabytesPerSecond->FromGigabytePerSecond")]
        public static BitRate FromGigabytesPerSecond(double gigabytespersecond)
        {
            decimal value = (decimal)gigabytespersecond;
            return new BitRate(value, BitRateUnit.GigabytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from KibibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKibibitsPerSecond->FromKibibitPerSecond")]
        public static BitRate FromKibibitsPerSecond(double kibibitspersecond)
        {
            decimal value = (decimal)kibibitspersecond;
            return new BitRate(value, BitRateUnit.KibibitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from KibibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKibibytesPerSecond->FromKibibytePerSecond")]
        public static BitRate FromKibibytesPerSecond(double kibibytespersecond)
        {
            decimal value = (decimal)kibibytespersecond;
            return new BitRate(value, BitRateUnit.KibibytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from KilobitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilobitsPerSecond->FromKilobitPerSecond")]
        public static BitRate FromKilobitsPerSecond(double kilobitspersecond)
        {
            decimal value = (decimal)kilobitspersecond;
            return new BitRate(value, BitRateUnit.KilobitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from KilobytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilobytesPerSecond->FromKilobytePerSecond")]
        public static BitRate FromKilobytesPerSecond(double kilobytespersecond)
        {
            decimal value = (decimal)kilobytespersecond;
            return new BitRate(value, BitRateUnit.KilobytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from MebibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMebibitsPerSecond->FromMebibitPerSecond")]
        public static BitRate FromMebibitsPerSecond(double mebibitspersecond)
        {
            decimal value = (decimal)mebibitspersecond;
            return new BitRate(value, BitRateUnit.MebibitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from MebibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMebibytesPerSecond->FromMebibytePerSecond")]
        public static BitRate FromMebibytesPerSecond(double mebibytespersecond)
        {
            decimal value = (decimal)mebibytespersecond;
            return new BitRate(value, BitRateUnit.MebibytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from MegabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegabitsPerSecond->FromMegabitPerSecond")]
        public static BitRate FromMegabitsPerSecond(double megabitspersecond)
        {
            decimal value = (decimal)megabitspersecond;
            return new BitRate(value, BitRateUnit.MegabitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from MegabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMegabytesPerSecond->FromMegabytePerSecond")]
        public static BitRate FromMegabytesPerSecond(double megabytespersecond)
        {
            decimal value = (decimal)megabytespersecond;
            return new BitRate(value, BitRateUnit.MegabytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from PebibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPebibitsPerSecond->FromPebibitPerSecond")]
        public static BitRate FromPebibitsPerSecond(double pebibitspersecond)
        {
            decimal value = (decimal)pebibitspersecond;
            return new BitRate(value, BitRateUnit.PebibitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from PebibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPebibytesPerSecond->FromPebibytePerSecond")]
        public static BitRate FromPebibytesPerSecond(double pebibytespersecond)
        {
            decimal value = (decimal)pebibytespersecond;
            return new BitRate(value, BitRateUnit.PebibytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from PetabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPetabitsPerSecond->FromPetabitPerSecond")]
        public static BitRate FromPetabitsPerSecond(double petabitspersecond)
        {
            decimal value = (decimal)petabitspersecond;
            return new BitRate(value, BitRateUnit.PetabitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from PetabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPetabytesPerSecond->FromPetabytePerSecond")]
        public static BitRate FromPetabytesPerSecond(double petabytespersecond)
        {
            decimal value = (decimal)petabytespersecond;
            return new BitRate(value, BitRateUnit.PetabytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from TebibitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTebibitsPerSecond->FromTebibitPerSecond")]
        public static BitRate FromTebibitsPerSecond(double tebibitspersecond)
        {
            decimal value = (decimal)tebibitspersecond;
            return new BitRate(value, BitRateUnit.TebibitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from TebibytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTebibytesPerSecond->FromTebibytePerSecond")]
        public static BitRate FromTebibytesPerSecond(double tebibytespersecond)
        {
            decimal value = (decimal)tebibytespersecond;
            return new BitRate(value, BitRateUnit.TebibytePerSecond);
        }

        /// <summary>
        ///     Get BitRate from TerabitsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTerabitsPerSecond->FromTerabitPerSecond")]
        public static BitRate FromTerabitsPerSecond(double terabitspersecond)
        {
            decimal value = (decimal)terabitspersecond;
            return new BitRate(value, BitRateUnit.TerabitPerSecond);
        }

        /// <summary>
        ///     Get BitRate from TerabytesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTerabytesPerSecond->FromTerabytePerSecond")]
        public static BitRate FromTerabytesPerSecond(double terabytespersecond)
        {
            decimal value = (decimal)terabytespersecond;
            return new BitRate(value, BitRateUnit.TerabytePerSecond);
        }

    }
}
