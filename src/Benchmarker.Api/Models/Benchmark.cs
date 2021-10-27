using System;
using System.ComponentModel.DataAnnotations;

namespace Benchmarker.Api.Models
{
    /// <summary>
    /// Class <c>Benchmark</c> models the workload data generated from two industrial benchmarks: 
    /// Netflix Data Benchmark (NDBench) and DVD store from Dell.
    /// </summary>
    public record Benchmark
    {
        [Key]
        [Required]
        public Guid Id { get; init; }

        [Required]
        public int CpuUtilization { get; init; }

        [Required]
        public int NetworkIn { get; init; }

        [Required]
        public int NetworkOut { get; init; }

        [Required]
        public double MemoryUtilization { get; init; }

        [Required]
        public string BenchmarkType { get; init; } = default!;

        [Required]
        public bool IsTrainingData { get; init; }

        [Required]
        public int SampleId { get; init; }
    }
}