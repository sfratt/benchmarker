namespace Benchmarker.Api.DataTransferObjects
{
    public record ResponseForData
    {
        public int Id { get; init; }
        public int CpuUtilization { get; init; }
        public int NetworkIn { get; init; }
        public int NetworkOut { get; init; }
        public double MemoryUtilization { get; init; }
    }
}