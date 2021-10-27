using System;
using System.Collections.Generic;

namespace Benchmarker.Domain.DataTransferObjects
{
    public record ResponseForData
    {
        /// <summary>Request for Workload ID (timestamp)</summary>
        public DateTime Id { get; init; }

        /// <summary>Last Batch ID</summary>
        public int BatchId { get; init; }

        ///<summary>Data samples requested</summary>
        public IEnumerable<string>? Data { get; init; }
    }
}