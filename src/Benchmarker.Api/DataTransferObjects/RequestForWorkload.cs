using System;

namespace Benchmarker.Api.DataTransferObjects
{
    public record RequestForWorkload
    {
        /// <summary>Request for Workload ID (timestamp)</summary>
        public DateTime Id { get; init; }

        /// <summary>Benchmark type (NDBench or DVDStore)</summary>
        public string? Benchmark { get; init; }

        /// <summary>Data type (training or testing)</summary>
        public string? Type { get; init; }

        /// <summary>CPU, NetworkIn, NetworkOut, or Memory</summary>
        public string? Metric { get; init; }

        /// <summary>Number of samples contained in each batch</summary>
        public int? BatchUnit { get; init; }

        /// <summary>Batch ID</summary>
        public int? BatchId { get; init; }

        /// <summary>Number of batches to return</summary>
        public int? BatchSize { get; init; }
    }
}