﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAlex.MathCore.ExpressionEvaluation.Trees;
using TAlex.MathCore.ExpressionEvaluation.Trees.Metadata;
using TAlex.MathCore.LinearAlgebra;
using TAlex.MathCore.Statistics;
using TAlex.MathCore.Statistics.Distributions;


namespace TAlex.MathCore.ExpressionEvaluation.ComplexExpressions.Functions
{
    [DisplayName("Median")]
    [Category(Categories.Statistics)]
    [Section(Sections.Averages)]
    [Description("Calculates the median of the elements of the matrix.")]
    [FunctionSignature("median", "real matrix m")]
    [ExampleUsage("median({2; 1; 5; 8; -11})", "2")]
    [ExampleUsage("median({1, 5; -1.2, 16})", "3")]
    public class MedianFuncExpression : UnaryExpression<Object>
    {
        public MedianFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.Median(SubExpression.EvaluateAsExpandableDoubleArray());
        }
    }

    [DisplayName("Mean")]
    [Category(Categories.Statistics)]
    [Section(Sections.Averages)]
    [Description("Calculates the arithmetic mean of the elements of the complex matrix.")]
    [FunctionSignature("mean", "complex matrix m")]
    [ExampleUsage("mean({2i; -1; 2.2; 0.6; -11})", "-1.84 + 0.4i")]
    [ExampleUsage("mean({6, 5; -1.2 + 13i, 16})", "6.45 + 3.25i")]
    public class MeanFuncExpression : UnaryExpression<Object>
    {
        public MeanFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.Mean(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Geometric mean")]
    [Category(Categories.Statistics)]
    [Section(Sections.Averages)]
    [Description("Calculates the geometric mean of the elements of the positive real matrix.")]
    [FunctionSignature("gmean", "real matrix m")]
    [ExampleUsage("gmean({2; 26; 2.2; 1; 1.1})", "2.63004840706915")]
    [ExampleUsage("gmean({0, 5; 1.2, 16})", "0")]
    public class GeometricMeanFuncExpression : UnaryExpression<Object>
    {
        public GeometricMeanFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.GeometricMean(SubExpression.EvaluateAsExpandableDoubleArray());
        }
    }

    [DisplayName("Harmonic mean")]
    [Category(Categories.Statistics)]
    [Section(Sections.Averages)]
    [Description("Calculates the harmonic mean of the elements of the positive real matrix.")]
    [FunctionSignature("hmean", "real matrix m")]
    [ExampleUsage("hmean({2; 26; 2.2; 1; 1.1})", "1.72289156626506")]
    [ExampleUsage("hmean({1, 5; 1.2, 16})", "1.90854870775348")]
    public class HarmonicMeanFuncExpression : UnaryExpression<Object>
    {
        public HarmonicMeanFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.HarmonicMean(SubExpression.EvaluateAsExpandableDoubleArray());
        }
    }

    [DisplayName("Mode")]
    [Category(Categories.Statistics)]
    [Section(Sections.Averages)]
    [Description("Calculates the harmonic mean of the elements of the positive real matrix.")]
    [FunctionSignature("mode", "complex matrix m")]
    [ExampleUsage("mode({-2; 33; 22.2i; 15; 33})", "33")]
    [ExampleUsage("mode({1, 5; 1, 16})", "1")]
    public class ModeFuncExpression : UnaryExpression<Object>
    {
        public ModeFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.Mode(SubExpression.EvaluateAsCMatrix());
        }
    }



    [DisplayName("Population variance")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the population variance of the elements of a complex matrix.")]
    [FunctionSignature("pvar", "complex matrix m")]
    [ExampleUsage("pvar({2; 3; 6; 8})", "5.6875")]
    [ExampleUsage("pvar({-2i, 18; 3.8, 3 - 6i})", "54.42")]
    [ExampleUsage("pvar({5})", "0")]
    public class PopulationVarianceFuncExpression : UnaryExpression<Object>
    {
        public PopulationVarianceFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.PopulationVariance(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Sample variance")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the sample variance of the elements of a complex matrix.")]
    [FunctionSignature("svar", "complex matrix m")]
    [ExampleUsage("svar({2; -13; 0; 8})", "78.25")]
    [ExampleUsage("svar({2, 2.8; -4.7, -2 - 3.5i})", "15.405")]
    [ExampleUsage("svar({-8i})", "0")]
    public class SampleVarianceFuncExpression : UnaryExpression<Object>
    {
        public SampleVarianceFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.SampleVariance(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Population std. deviation")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the square root of the population variance of the elements of a complex matrix.")]
    [FunctionSignature("pstdev", "complex matrix m")]
    [ExampleUsage("pstdev({2; 3; 6; 8})", "2.38484800354236")]
    [ExampleUsage("pstdev({-2i, 18; 3.8, 3 - 6i})", "7.3769912566032")]
    [ExampleUsage("pstdev({5})", "0")]
    public class PopulationStandardDeviationFuncExpression : UnaryExpression<Object>
    {
        public PopulationStandardDeviationFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.PopulationStandardDeviation(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Sample std. deviation")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the square root of the sample variance of the elements of a complex matrix.")]
    [FunctionSignature("sstdev", "complex matrix m")]
    [ExampleUsage("sstdev({2; -13; 0; 8})", "8.84590300647707")]
    [ExampleUsage("sstdev({2, 2.8; -4.7, -2 - 3.5i})", "3.92492038135807")]
    [ExampleUsage("sstdev({12})", "0")]
    public class SampleStandardDeviationFuncExpression : UnaryExpression<Object>
    {
        public SampleStandardDeviationFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return (Complex)MathStats.SampleStandardDeviation(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Population skewness")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the population skewness of the elements of a complex matrix.")]
    [FunctionSignature("pskew", "complex matrix m")]
    [ExampleUsage("pskew({2.2; -6; 0; 6})", "-0.349105920180674")]
    [ExampleUsage("pskew({-2i, 18; 3.8, 3 - 6i})", "1.32062163212182 - 0.023737045200059i")]
    public class PopulationSkewnessFuncExpression : UnaryExpression<Object>
    {
        public PopulationSkewnessFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return MathStats.PopulationSkewness(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Sample skewness")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the sample skewness of the elements of a complex matrix.")]
    [FunctionSignature("sskew", "complex matrix m")]
    [ExampleUsage("sskew({0.4; -6; 4; 6})", "-0.984814784355962")]
    [ExampleUsage("sskew({-4i + 5, 1.3; 13.1, 3 - 6i})", "4.03612644357173 + 0.295132430675187i")]
    public class SampleSkewnessFuncExpression : UnaryExpression<Object>
    {
        public SampleSkewnessFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return MathStats.SampleSkewness(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Population kurtosis")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the population kurtosis of the elements of a complex matrix.")]
    [FunctionSignature("pkurt", "complex matrix m")]
    [ExampleUsage("pkurt({-14; 13; 2; -66})", "-0.928968973993598")]
    [ExampleUsage("pkurt({-22, 2 - 18.4i; 0, 3})", "-1.81674986052611 + 2.79477015182896i")]
    public class PopulationKurtosisFuncExpression : UnaryExpression<Object>
    {
        public PopulationKurtosisFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return MathStats.PopulationKurtosis(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Sample kurtosis")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the sample kurtosis of the elements of a complex matrix.")]
    [FunctionSignature("skurt", "complex matrix m")]
    [ExampleUsage("skurt({-14; 13; 2; -66})", "2.03273269504801")]
    [ExampleUsage("skurt({-22, 2 - 18.4i; 0, 3})", "-4.62562395394586 + 20.9607761387172i")]
    public class SampleKurtosisFuncExpression : UnaryExpression<Object>
    {
        public SampleKurtosisFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return MathStats.SampleKurtosis(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Moment")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the moment of a specific order of the elements of a complex matrix.")]
    [FunctionSignature("moment", "complex matrix m", "integer order")]
    [ExampleUsage("moment({-14; 13; 2; -66}, 2)", "1181.25")]
    [ExampleUsage("moment({-22, 2 - 18.4i; 0, 3}, 3)", "-3161.09 + 1502.176i")]
    public class MomentFuncExpression : BinaryExpression<Object>
    {
        public MomentFuncExpression(Expression<Object> mExpression, Expression<Object> orderExpression)
            : base(mExpression, orderExpression)
        {
        }

        public override object Evaluate()
        {
            CMatrix m = LeftExpression.EvaluateAsCMatrix();
            int order = RightExpression.EvaluateAsInt32();

            return MathStats.PopulationMoment(m, order);
        }
    }

    [DisplayName("Central moment")]
    [Category(Categories.Statistics)]
    [Section(Sections.Moments)]
    [Description("Calculates the central moment of a specific order of the elements of a complex matrix.")]
    [FunctionSignature("cmoment", "complex matrix m", "integer order")]
    [ExampleUsage("cmoment({-14; 13; 2; -66}, 2)", "917.1875")]
    [ExampleUsage("cmoment({-22, 2 - 18.4i; 0, 3}, 3)", "-2016.09375 + 1510.341i")]
    public class CentralMomentFuncExpression : BinaryExpression<Object>
    {
        public CentralMomentFuncExpression(Expression<Object> mExpression, Expression<Object> orderExpression)
            : base(mExpression, orderExpression)
        {
        }

        public override object Evaluate()
        {
            CMatrix m = LeftExpression.EvaluateAsCMatrix();
            int order = RightExpression.EvaluateAsInt32();

            return MathStats.PopulationCentralMoment(m, order);
        }
    }


    [DisplayName("Population covariance")]
    [Category(Categories.Statistics)]
    [Section(Sections.CovarianceAndCorrelation)]
    [Description("Calculates the population covariance of two sets of values.")]
    [FunctionSignature("pcov", "complex matrix m1", "complex matrix m2")]
    [ExampleUsage("pcov({-14; 13; 2; -66}, {1; 1.4; -111; 5.5})", "-564.04375")]
    [ExampleUsage("pcov({-22, 2 - 18.4i; 0, 3}, {2.4i, 3.3; 44, -0.2})", "54.30375 + 49.635i")]
    public class PopulationCovarianceFuncExpression : BinaryExpression<Object>
    {
        public PopulationCovarianceFuncExpression(Expression<Object> m1Expression, Expression<Object> m2Expression)
            : base(m1Expression, m2Expression)
        {
        }

        public override object Evaluate()
        {
            IList<Complex> m1 = LeftExpression.EvaluateAsExpandableComplexArray();
            IList<Complex> m2 = RightExpression.EvaluateAsExpandableComplexArray();

            return MathStats.PopulationCovariance(m1, m2);
        }
    }
    
    [DisplayName("Sample covariance")]
    [Category(Categories.Statistics)]
    [Section(Sections.CovarianceAndCorrelation)]
    [Description("Calculates the sample covariance of two sets of values.")]
    [FunctionSignature("scov", "complex matrix m1", "complex matrix m2")]
    [ExampleUsage("scov({-14; 13; 2; -66}, {1; 1.4; -111; 6.6})", "-770.3")]
    [ExampleUsage("scov({-22, 2 - 18.4i; 0, 3}, {2.4i, 3.3; 44, -0.2})", "72.405 + 66.18i")]
    public class SampleCovarianceFuncExpression : BinaryExpression<Object>
    {
        public SampleCovarianceFuncExpression(Expression<Object> m1Expression, Expression<Object> m2Expression)
            : base(m1Expression, m2Expression)
        {
        }

        public override object Evaluate()
        {
            IList<Complex> m1 = LeftExpression.EvaluateAsExpandableComplexArray();
            IList<Complex> m2 = RightExpression.EvaluateAsExpandableComplexArray();

            return MathStats.SampleCovariance(m1, m2);
        }
    }

    [DisplayName("Correlation")]
    [Category(Categories.Statistics)]
    [Section(Sections.CovarianceAndCorrelation)]
    [Description("Calculates the Pearson correlation of two sets of values.")]
    [FunctionSignature("corr", "complex matrix m1", "complex matrix m2")]
    [ExampleUsage("corr({-14; 13; 2; -66}, {1; 1.4; -111; 6.6})", "-0.3860576577199")]
    [ExampleUsage("corr({-22, 2 - 18.4i; 0, 3}, {-21, 2.5 - 18.4i; 3, 2})", "0.993950652653727 + 0.0102431643927006i")]
    public class CorrelationFuncExpression : BinaryExpression<Object>
    {
        public CorrelationFuncExpression(Expression<Object> m1Expression, Expression<Object> m2Expression)
            : base(m1Expression, m2Expression)
        {
        }

        public override object Evaluate()
        {
            IList<Complex> m1 = LeftExpression.EvaluateAsExpandableComplexArray();
            IList<Complex> m2 = RightExpression.EvaluateAsExpandableComplexArray();

            return MathStats.Correlation(m1, m2);
        }
    }


    [DisplayName("Sum")]
    [Category(Categories.Statistics)]
    [Section(Sections.SumAndProduct)]
    [Description("Calculates the sum of the elements of a complex matrix.")]
    [FunctionSignature("sum", "complex matrix m")]
    [ExampleUsage("sum({-12; 15; 2; 6.6})", "11.6")]
    [ExampleUsage("sum({-14i, 2 - 0.2i; 2, 3 - 3i})", "7 - 17.2i")]
    public class SumFuncExpression : UnaryExpression<Object>
    {
        public SumFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return MathStats.Sum(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Sum of squares")]
    [Category(Categories.Statistics)]
    [Section(Sections.SumAndProduct)]
    [Description("Calculates the sum of squares of the elements of a complex matrix.")]
    [FunctionSignature("sumsq", "complex matrix m")]
    [ExampleUsage("sumsq({-12; 15; 2; 6.6})", "416.56")]
    [ExampleUsage("sumsq({-14i, 2 - 0.2i; 2, 3 - 3i})", "-188.04 - 18.8i")]
    public class SumOfSquaresFuncExpression : UnaryExpression<Object>
    {
        public SumOfSquaresFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return MathStats.SumOfSquares(SubExpression.EvaluateAsCMatrix());
        }
    }

    [DisplayName("Product")]
    [Category(Categories.Statistics)]
    [Section(Sections.SumAndProduct)]
    [Description("Calculates the product of the elements of a complex matrix.")]
    [FunctionSignature("prod", "complex matrix m")]
    [ExampleUsage("prod({-12; 15; 2; 6.6})", "-2376")]
    [ExampleUsage("prod({-12; 15; 0; 6.6})", "0")]
    [ExampleUsage("prod({-14i, 2 - 0.2i; 2, 3 - 3i})", "-184.8 - 151.2i")]
    public class ProductFuncExpression : UnaryExpression<Object>
    {
        public ProductFuncExpression(Expression<Object> mExpression)
            : base(mExpression)
        {
        }

        public override object Evaluate()
        {
            return MathStats.Product(SubExpression.EvaluateAsCMatrix());
        }
    }


    [DisplayName("Histogram")]
    [Category(Categories.Statistics)]
    [Section(Sections.Histogram)]
    [Description("Returns an array containing the frequencies of occurrence of values in specified intervals.")]
    [FunctionSignature("hist", "real vector v")]
    [FunctionSignature("hist", "real vector v", "integer intvals")]
    [FunctionSignature("hist", "real vector v", "real vector intvals")]
    [ExampleUsage("hist({15; 28; 6.6; 6; -12})", "{0.2; 0.4; 0.4}")]
    [ExampleUsage("hist({-12; -3; 6.6; -10}, 2)", "{0.75; 0.25}")]
    [ExampleUsage("hist({-12; 15; 0; 6.6}, {-15; 5; 30})", "{0.5; 0.5}")]
    public class HistogramFuncExpression : BinaryExpression<Object>
    {
        public HistogramFuncExpression(Expression<Object> vExpression)
            : this(vExpression, Expression<Object>.Null)
        {
        }

        public HistogramFuncExpression(Expression<Object> vExpression, Expression<Object> intvalsExpression)
            : base(vExpression, intvalsExpression)
        {
        }

        public override object Evaluate()
        {
            IList<double> v = LeftExpression.EvaluateAsRealVector();

            if (RightExpression == Expression<Object>.Null)
            {
                return new CMatrix(MathStats.Histogram(v));
            }
            else
            {
                object intvals = RightExpression.Evaluate();
                if (intvals is Complex)
                    return new CMatrix(MathStats.Histogram(v, ExpressionExtensions.AsInt32((Complex)intvals)));
                else if (intvals is CMatrix)
                    return new CMatrix(MathStats.Histogram(v, ExpressionExtensions.AsRealVector((CMatrix)intvals)));
                else
                    throw ExceptionHelper.ThrowWrongArgumentType(intvals);
            }
        }
    }
}
