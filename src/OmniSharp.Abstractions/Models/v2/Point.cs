using System;
using Newtonsoft.Json;

namespace OmniSharp.Models.V2
{
    public record Point : IEquatable<Point>
    {
        [JsonConverter(typeof(ZeroBasedIndexConverter))]
        public int Line { get; init; }

        [JsonConverter(typeof(ZeroBasedIndexConverter))]
        public int Column { get; init; }
    }
}
