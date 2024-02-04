using System;


namespace R5T.F0052
{
    public static class Instances
    {
        public static F0053.ICodeFileNameOperator CodeFileNameOperator => F0053.CodeFileNameOperator.Instance;
        public static IDirectoryNames DirectoryNames { get; } = F0052.DirectoryNames.Instance;
        public static IFileExtensions FileExtensions { get; } = F0052.FileExtensions.Instance;
        public static L0066.IFileExtensionOperator FileExtensionOperator { get; } = L0066.FileExtensionOperator.Instance;
        public static IFileNames FileNames { get; } = F0052.FileNames.Instance;
        public static L0066.IPathOperator PathOperator { get; } = L0066.PathOperator.Instance;
        public static IProjectDirectoryNameOperator ProjectDirectoryNameOperator { get; } = F0052.ProjectDirectoryNameOperator.Instance;
        public static IProjectFileNameOperator ProjectFileNameOperator { get; } = F0052.ProjectFileNameOperator.Instance;
    }
}