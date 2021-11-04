using System;
using Benchmarker.Domain.Models;
using Xunit;

namespace Benchmarker.Domain.Tests
{
    public class BenchmarkTests
    {
        [Fact]
        public void CheckBenchmarkValuesAreCorrect()
        {
            // Arrange
            var benchmark = new Benchmark
            {
                Id = new Guid(),
                CpuUtilization = 39,
                NetworkIn = 199985900,
                NetworkOut = 181947520,
                MemoryUtilization = 68.09846248,
                BenchmarkType = "ndbench",
                IsTrainingData = true,
                SampleId = 1
            };

            // Act

            // Assert
            Assert.Equal(39, benchmark.CpuUtilization);
            Assert.Equal(199985900, benchmark.NetworkIn);
            Assert.Equal(181947520, benchmark.NetworkOut);
            Assert.Equal(68.09846248, benchmark.MemoryUtilization);
            Assert.Equal("ndbench", benchmark.BenchmarkType);
            Assert.True(benchmark.IsTrainingData);
            Assert.Equal(1, benchmark.SampleId);
        }

        [Fact]
        public void CheckBenchmarkTypesAreCorrect()
        {
            // Arrange
            var benchmark = new Benchmark
            {
                Id = new Guid(),
                CpuUtilization = 39,
                NetworkIn = 199985900,
                NetworkOut = 181947520,
                MemoryUtilization = 68.09846248,
                BenchmarkType = "ndbench",
                IsTrainingData = true,
                SampleId = 1
            };

            // Act

            // Assert
            Assert.IsType<Guid>(benchmark.Id);
            Assert.IsType<int>(benchmark.CpuUtilization);
            Assert.IsType<int>(benchmark.NetworkIn);
            Assert.IsType<int>(benchmark.NetworkOut);
            Assert.IsType<double>(benchmark.MemoryUtilization);
            Assert.IsType<string>(benchmark.BenchmarkType);
            Assert.IsType<bool>(benchmark.IsTrainingData);
            Assert.IsType<int>(benchmark.SampleId);
        }
    }
}
