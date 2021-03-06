﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtSine.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines HtSine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static HtSine HtSine(int startIdx, int endIdx, double[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outSine = new double[endIdx - startIdx + 1];
            double[] outLeadSine = new double[endIdx - startIdx + 1];

            var retCode = TACore.HtSine(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outSine, outLeadSine);
            return new HtSine(retCode, outBegIdx, outNBElement, outSine, outLeadSine);
        }

        public static HtSine HtSine(int startIdx, int endIdx, float[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outSine = new double[endIdx - startIdx + 1];
            double[] outLeadSine = new double[endIdx - startIdx + 1];

            var retCode = TACore.HtSine(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outSine, outLeadSine);
            return new HtSine(retCode, outBegIdx, outNBElement, outSine, outLeadSine);
        }
    }

    public class HtSine : IndicatorBase
    {
        public HtSine(RetCode retCode, int begIdx, int nbElement, double[] sine, double[] leadSine)
            : base(retCode, begIdx, nbElement)
        {
            this.Sine = sine;
            this.LeadSine = leadSine;
        }

        public double[] LeadSine { get; }

        public double[] Sine { get; }
    }
}