using System.ComponentModel.DataAnnotations;

namespace Benchmarker.Api.Models
{
    /// <summary>
    /// Class <c>Benchmark</c> models the Netflix Data Benchmark training data set.
    /// </summary>
    public class Benchmark
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int CpuUtilization { get; set; }

        [Required]
        public int NetworkIn { get; set; }

        [Required]
        public int NetworkOut { get; set; }

        [Required]
        public double MemoryUtilization { get; set; }
    }
}