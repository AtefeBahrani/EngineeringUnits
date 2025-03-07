﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Area
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Area FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new Area(value, AreaUnit.SI);
        //}


        /// <summary>
        ///     Get Area from Acres.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromAcres->FromAcre")]
        public static Area FromAcres(double acres)
        {
            double value = (double)acres;
            return new Area(value, AreaUnit.Acre);
        }
        /// <summary>
        ///     Get Area from Hectares.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromHectares->FromHectare")]
        public static Area FromHectares(double hectares)
        {
            double value = (double)hectares;
            return new Area(value, AreaUnit.Hectare);
        }
        /// <summary>
        ///     Get Area from SquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareCentimeters->FromSquareCentimeter")]
        public static Area FromSquareCentimeters(double squarecentimeters)
        {
            double value = (double)squarecentimeters;
            return new Area(value, AreaUnit.SquareCentimeter);
        }
        /// <summary>
        ///     Get Area from SquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareDecimeters->FromSquareDecimeter")]
        public static Area FromSquareDecimeters(double squaredecimeters)
        {
            double value = (double)squaredecimeters;
            return new Area(value, AreaUnit.SquareDecimeter);
        }
        /// <summary>
        ///     Get Area from SquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular form - FromSquareFeet->FromSquareFoot")]
        public static Area FromSquareFeet(double squarefeet)
        {
            double value = (double)squarefeet;
            return new Area(value, AreaUnit.SquareFoot);
        }
        /// <summary>
        ///     Get Area from SquareInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareInches->FromSquareInch")]
        public static Area FromSquareInches(double squareinches)
        {
            double value = (double)squareinches;
            return new Area(value, AreaUnit.SquareInch);
        }
        /// <summary>
        ///     Get Area from SquareKilometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareKilometers->FromSquareKilometer")]
        public static Area FromSquareKilometers(double squarekilometers)
        {
            double value = (double)squarekilometers;
            return new Area(value, AreaUnit.SquareKilometer);
        }
        /// <summary>
        ///     Get Area from SquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareMeters->FromSquareMeter")]
        public static Area FromSquareMeters(double squaremeters)
        {
            double value = (double)squaremeters;
            return new Area(value, AreaUnit.SquareMeter);
        }
        /// <summary>
        ///     Get Area from SquareMicrometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareMicrometers->FromSquareMicrometer")]
        public static Area FromSquareMicrometers(double squaremicrometers)
        {
            double value = (double)squaremicrometers;
            return new Area(value, AreaUnit.SquareMicrometer);
        }
        /// <summary>
        ///     Get Area from SquareMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareMiles->FromSquareMile")]
        public static Area FromSquareMiles(double squaremiles)
        {
            double value = (double)squaremiles;
            return new Area(value, AreaUnit.SquareMile);
        }
        /// <summary>
        ///     Get Area from SquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareMillimeters->FromSquareMillimeter")]
        public static Area FromSquareMillimeters(double squaremillimeters)
        {
            double value = (double)squaremillimeters;
            return new Area(value, AreaUnit.SquareMillimeter);
        }
        /// <summary>
        ///     Get Area from SquareNauticalMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareNauticalMiles->FromSquareNauticalMile")]
        public static Area FromSquareNauticalMiles(double squarenauticalmiles)
        {
            double value = (double)squarenauticalmiles;
            return new Area(value, AreaUnit.SquareNauticalMile);
        }
        /// <summary>
        ///     Get Area from SquareYards.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSquareYards->FromSquareYard")]
        public static Area FromSquareYards(double squareyards)
        {
            double value = (double)squareyards;
            return new Area(value, AreaUnit.SquareYard);
        }
        /// <summary>
        ///     Get Area from UsSurveySquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Area FromUsSurveySquareFeet(double ussurveysquarefeet)
        //{
        //    double value = (double)ussurveysquarefeet;
        //    return new Area(value, AreaUnit.UsSurveySquareFoot);
        //}

    }
}
