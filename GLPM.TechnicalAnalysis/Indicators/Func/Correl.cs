﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Correl.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Correl.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Correl Correl(int startIdx, int endIdx, double[] real0, double[] real1, int timePeriod = 30)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Correl(
                startIdx,
                endIdx,
                real0,
                real1,
                timePeriod,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new Correl(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Correl Correl(int startIdx, int endIdx, float[] real0, float[] real1, int timePeriod = 30)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Correl(
                startIdx,
                endIdx,
                real0,
                real1,
                timePeriod,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new Correl(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Correl : IndicatorBase
    {
        public Correl(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}