#nullable enable

using System.Collections.Generic;
using OmniSharp.Models.Metadata;
using OmniSharp.Models.v1.SourceGeneratedFile;

namespace OmniSharp.Models.GotoTypeDefinition
{
    public record GotoTypeDefinitionResponse
    {
        public List<TypeDefinition>? Definitions { get; init; }
    }

    public record TypeDefinition
    {
        public V2.Location Location { get; init; } = null!;
        public MetadataSource? MetadataSource { get; init; }
        public SourceGeneratedFileInfo? SourceGeneratedFileInfo { get; init; }
    }
}
