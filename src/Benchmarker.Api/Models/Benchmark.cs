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
        public int Id { get; init; }

        [Required]
        public int CpuUtilization { get; init; }

        [Required]
        public int NetworkIn { get; init; }

        [Required]
        public int NetworkOut { get; init; }

        [Required]
        public double MemoryUtilization { get; init; }

        // [Required]
        // public bool IsTraining { get; init; }
    }
}