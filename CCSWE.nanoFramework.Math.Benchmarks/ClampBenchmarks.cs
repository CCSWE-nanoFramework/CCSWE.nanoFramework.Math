using nanoFramework.Benchmark;
using nanoFramework.Benchmark.Attributes;

namespace CCSWE.nanoFramework.Benchmarks
{
    [IterationCount(Iterations)]
    public class ClampBenchmarks: BenchmarksBase
    {
        [Benchmark]
        public void Clamp_Double_Fast()
        {
            RunIterations(Loops, () =>
            {
                var result = FastMath.Clamp(DoublePositive1, DoubleNegative1, DoublePositive2);
            });
        }

        [Benchmark]
        public void Clamp_Double_Math()
        {
            RunIterations(Loops, () =>
            {
                var result = Math.Clamp(DoublePositive1, DoubleNegative1, DoublePositive2);
            });
        }

        [Benchmark]
        public void Clamp_System_Double_Math()
        {
            RunIterations(Loops, () =>
            {
                var result = Math.Clamp_System(DoublePositive1, DoubleNegative1, DoublePositive2);
            });
        }

        [Benchmark]
        public void Clamp_Double_System()
        {
            RunIterations(Loops, () =>
            {
                var result = System.Math.Clamp(DoublePositive1, DoubleNegative1, DoublePositive2);
            });
        }

        [Benchmark]
        public void Clamp_Float_Fast()
        {
            RunIterations(Loops, () =>
            {
                var result = FastMath.Clamp(FloatPositive1, FloatNegative1, FloatPositive2);
            });
        }

        [Benchmark]
        public void Clamp_Float_Math()
        {
            RunIterations(Loops, () =>
            {
                var result = Math.Clamp(FloatPositive1, FloatNegative1, FloatPositive2);
            });
        }

        [Benchmark]
        public void Clamp_System_Float_Math()
        {
            RunIterations(Loops, () =>
            {
                var result = Math.Clamp_System(FloatPositive1, FloatNegative1, FloatPositive2);
            });
        }

        [Benchmark]
        public void Clamp_Float_System()
        {
            RunIterations(Loops, () =>
            {
                var result = System.Math.Clamp(FloatPositive1, FloatNegative1, FloatPositive2);
            });
        }

        [Benchmark]
        public void Clamp_Long_Fast()
        {
            RunIterations(Loops, () =>
            {
                var result = FastMath.Clamp(LongPositive1, LongNegative1, LongPositive2);
            });
        }

        [Benchmark]
        public void Clamp_Long_Math()
        {
            RunIterations(Loops, () =>
            {
                var result = Math.Clamp(LongPositive1, LongNegative1, LongPositive2);
            });
        }

        [Benchmark]
        public void Clamp_Long_System()
        {
            RunIterations(Loops, () =>
            {
                var result = System.Math.Clamp(LongPositive1, LongNegative1, LongPositive2);
            });
        }

        [Benchmark]
        public void Clamp_ULong_Fast()
        {
            RunIterations(Loops, () =>
            {
                var result = FastMath.Clamp(ULongLow, ULongMid, ULongHigh);
            });
        }

        [Benchmark]
        public void Clamp_ULong_Math()
        {
            RunIterations(Loops, () =>
            {
                var result = Math.Clamp(ULongLow, ULongMid, ULongHigh);
            });
        }

        [Benchmark]
        public void Clamp_ULong_System()
        {
            RunIterations(Loops, () =>
            {
                var result = System.Math.Clamp(ULongLow, ULongMid, ULongHigh);
            });
        }
    }
}
