﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CdlBeltHold.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines CdlBeltHold.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static CdlBeltHold CdlBeltHold(
            int startIdx,
            int endIdx,
            double[] open,
            double[] high,
            double[] low,
            double[] close)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            int[] outInteger = new int[endIdx - startIdx + 1];

            var retCode = TACore.CdlBeltHold(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                ref outBegIdx,
                ref outNBElement,
                outInteger);
            return new CdlBeltHold(retCode, outBegIdx, outNBElement, outInteger);
        }

        public static CdlBeltHold CdlBeltHold(
            int startIdx,
            int endIdx,
            float[] open,
            float[] high,
            float[] low,
            float[] close)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            int[] outInteger = new int[endIdx - startIdx + 1];

            var retCode = TACore.CdlBeltHold(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                ref outBegIdx,
                ref outNBElement,
                outInteger);
            return new CdlBeltHold(retCode, outBegIdx, outNBElement, outInteger);
        }
    }

    public class CdlBeltHold : IndicatorBase
    {
        public CdlBeltHold(RetCode retCode, int begIdx, int nbElement, int[] integer)
            : base(retCode, begIdx, nbElement)
        {
            this.Integer = integer;
        }

        public int[] Integer { get; }
    }
}