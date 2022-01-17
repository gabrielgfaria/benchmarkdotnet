using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace benchmark
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Benchmarker
    {
        private const string DateTime = "2019-12-13T16:33:06Z";
        private static readonly Benchmarkable benchmarkable = new Benchmarkable();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            benchmarkable.GetYearFromDateTime(DateTime); 
        }

        [Benchmark]
        public void GetYearFromSplit()
        {
            benchmarkable.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            benchmarkable.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            benchmarkable.GetYearFromSpan(DateTime);
        }        
        
        [Benchmark]
        public void GetYearFromSpanWithManualConversion()
        {
            benchmarkable.GetYearFromSpanWithManualConversion(DateTime);
        }
    }
}