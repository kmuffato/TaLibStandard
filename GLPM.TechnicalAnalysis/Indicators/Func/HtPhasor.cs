﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtPhasor.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines HtPhasor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static HtPhasor HtPhasor(int startIdx, int endIdx, double[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outInPhase = new double[endIdx - startIdx + 1];
            double[] outQuadrature = new double[endIdx - startIdx + 1];

            var retCode = TACore.HtPhasor(
                startIdx,
                endIdx,
                real,
                ref outBegIdx,
                ref outNBElement,
                outInPhase,
                outQuadrature);
            return new HtPhasor(retCode, outBegIdx, outNBElement, outInPhase, outQuadrature);
        }

        public static HtPhasor HtPhasor(int startIdx, int endIdx, float[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outInPhase = new double[endIdx - startIdx + 1];
            double[] outQuadrature = new double[endIdx - startIdx + 1];

            var retCode = TACore.HtPhasor(
                startIdx,
                endIdx,
                real,
                ref outBegIdx,
                ref outNBElement,
                outInPhase,
                outQuadrature);
            return new HtPhasor(retCode, outBegIdx, outNBElement, outInPhase, outQuadrature);
        }
    }

    public class HtPhasor : IndicatorBase
    {
        public HtPhasor(RetCode retCode, int begIdx, int nbElement, double[] inPhase, double[] quadrature)
            : base(retCode, begIdx, nbElement)
        {
            this.InPhase = inPhase;
            this.Quadrature = quadrature;
        }

        public double[] InPhase { get; }

        public double[] Quadrature { get; }
    }
}