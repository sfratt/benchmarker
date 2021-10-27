using System;
using System.ComponentModel.DataAnnotations;

namespace Benchmarker.Api.DataTransferObjects
{
    public record RequestForWorkload
    {
        /// <summary>
        /// Request for Workload ID (timestamp)
        /// </summary>
        [Required]
        public DateTime Id { get; init; }

        /// <summary>
        /// Benchmark type (NDBench or DVDStore)
        /// </summary>
        [Required]
        public string BenchmarkType { get; init; } = default!;

        /// <summary>
        /// Data type (training or testing)
        /// </summary>
        public string DataType { get; init; } = default!;

        /// <summary>
        /// CPU, NetworkIn, NetworkOut, or Memory
        /// </summary>
        public string Metric { get; init; } = default!;

        /// <summary>
        /// Number of samples contained in each batch
        /// </summary>
        // [Range(10, 1000)]
        public int? BatchUnit { get; init; }

        /// <summary>
        /// Batch ID
        /// </summary>
        public int? BatchId { get; init; }

        /// <summary>
        /// Number of batches to return
        /// </summary>
        public int? BatchSize { get; init; }
    }
}