using System;
using System.ComponentModel.DataAnnotations;

namespace Benchmarker.Domain.DataTransferObjects
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
        [Required]
        public string DataType { get; init; } = default!;

        /// <summary>
        /// CPU, NetworkIn, NetworkOut, or Memory
        /// </summary>
        [Required]
        public string Metric { get; init; } = default!;

        /// <summary>
        /// Number of samples contained in each batch
        /// </summary>
        [Required]
        [Range(1, 1000)]
        public int BatchUnit { get; init; }

        /// <summary>
        /// Batch ID
        /// </summary>
        [Required]
        // [Range(0, 1000)]
        public int BatchId { get; init; }

        /// <summary>
        /// Number of batches to return
        /// </summary>
        [Required]
        public int BatchSize { get; init; }
    }
}