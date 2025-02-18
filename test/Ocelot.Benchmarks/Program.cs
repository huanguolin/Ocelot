﻿using BenchmarkDotNet.Running;

namespace Ocelot.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[] {
                    typeof(DictionaryBenchmarks),
                    typeof(UrlPathToUrlPathTemplateMatcherBenchmarks),
                    typeof(AllTheThingsBenchmarks),
                    typeof(ExceptionHandlerMiddlewareBenchmarks),
                    typeof(DownstreamRouteFinderMiddlewareBenchmarks),
                    typeof(SerilogBenchmarks),
                    typeof(MsLoggerBenchmarks),
               });

            switcher.Run(args);
        }
    }
}
