using System.Runtime.CompilerServices;
using OmniSharp;

[assembly: InternalsVisibleTo("OmniSharp" + OmniSharpPublicKey.Key)]
[assembly: InternalsVisibleTo("TestUtility" + OmniSharpPublicKey.Key)]
[assembly: InternalsVisibleTo("OmniSharp.Stdio.Tests" + OmniSharpPublicKey.Key)]
