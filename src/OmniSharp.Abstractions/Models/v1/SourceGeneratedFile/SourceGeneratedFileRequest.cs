#nullable enable

using System;
using OmniSharp.Mef;

namespace OmniSharp.Models.v1.SourceGeneratedFile
{
    [OmniSharpEndpoint(
        OmniSharpEndpoints.SourceGeneratedFile,
        typeof(SourceGeneratedFileRequest),
        typeof(SourceGeneratedFileResponse)
    )]
    public sealed record SourceGeneratedFileRequest : SourceGeneratedFileInfo, IRequest { }
}
