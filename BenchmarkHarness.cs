using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using System;
using System.Threading.Tasks;



namespace BenchmarkApplication
{

    public class Config : ManualConfig
    {
        public Config()
        {
            AddExporter(CsvExporter.Default);
            AddExporter(RPlotExporter.Default);
        }
    }
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RPlotExporter, HtmlExporter, MarkdownExporter, CsvExporter]
    [RankColumn(NumeralSystem.Arabic)]
    public class BenchmarkHarness
    {

        [Params(1, 100)]
        public int IterationCount;

        private readonly Client _client = new();

        private readonly string _endpoint = "http://localhost:5000/api/information/";

        //[Benchmark]
        //public async Task WhereCountGetSmallPayloadAsync()
        //{
        //    for (int i = 0; i < IterationCount; i++)
        //    {
        //        await _client.GetSmallPayloadAsync(_endpoint + "WhereCount");
        //    }
        //}

        //[Benchmark]
        //public async Task DirectCountGetSmallPayloadAsync()
        //{
        //    for (int i = 0; i < IterationCount; i++)
        //    {
        //        await _client.GetSmallPayloadAsync(_endpoint + "DirectCount");
        //    }
        //}

        //[Benchmark]
        //public async Task SqlWhereCountGetSmallPayloadAsync()
        //{
        //    for (int i = 0; i < IterationCount; i++)
        //    {
        //        await _client.GetSmallPayloadAsync(_endpoint + "SqlWhereCount");
        //    }
        //}



        [Benchmark]
        public async Task HashSetCountGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await _client.GetSmallPayloadAsync(_endpoint + "HashSetCount");
            }
        }
        [Benchmark]
        public async Task DistinctCountGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await _client.GetSmallPayloadAsync(_endpoint + "DistinctCount");
            }
        }

        [Benchmark]
        public async Task SqlAndDistinctCountGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await _client.GetSmallPayloadAsync(_endpoint + "SqlAndDistinctCount");
            }
        }

        [Benchmark]
        public async Task SqlCountGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await _client.GetSmallPayloadAsync(_endpoint + "SqlCount");
            }
        }
    }
}