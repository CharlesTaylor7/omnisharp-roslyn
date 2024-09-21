namespace OmniSharp
{
    internal static class Configuration
    {
        public static bool ZeroBasedIndices = false;

        public const string RoslynVersion = "4.12.0.0";
        public const string RoslynPublicKeyToken = "31bf3856ad364e35";

        public static readonly string RoslynFeatures = GetRoslynAssemblyFullName(
            "Microsoft.CodeAnalysis.Features"
        );
        public static readonly string RoslynCSharpFeatures = GetRoslynAssemblyFullName(
            "Microsoft.CodeAnalysis.CSharp.Features"
        );
        public static readonly string RoslynOmniSharpExternalAccess = GetRoslynAssemblyFullName(
            "Microsoft.CodeAnalysis.ExternalAccess.OmniSharp"
        );
        public static readonly string RoslynOmniSharpExternalAccessCSharp =
            GetRoslynAssemblyFullName("Microsoft.CodeAnalysis.ExternalAccess.OmniSharp.CSharp");
        public static readonly string RoslynWorkspaces = GetRoslynAssemblyFullName(
            "Microsoft.CodeAnalysis.Workspaces"
        );
        public static readonly string OmniSharpMiscProjectName = "OmniSharpMiscellaneousFiles";

        private static string GetRoslynAssemblyFullName(string name)
        {
            return $"{name}, Version={RoslynVersion}, Culture=neutral, PublicKeyToken={RoslynPublicKeyToken}";
        }
    }
}
