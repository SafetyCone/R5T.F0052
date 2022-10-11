using System;

using R5T.F0000;
using R5T.F0002;


namespace R5T.F0052
{
    public static class Instances
    {
        public static IDirectoryNames DirectoryNames { get; } = F0052.DirectoryNames.Instance;
        public static IFileExtensions FileExtensions { get; } = F0052.FileExtensions.Instance;
        public static IFileExtensionOperator FileExtensionOperator { get; } = F0000.FileExtensionOperator.Instance;
        public static IFileNames FileNames { get; } = F0052.FileNames.Instance;
        public static F0002.IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static IProjectDirectoryNameOperator ProjectDirectoryNameOperator { get; } = F0052.ProjectDirectoryNameOperator.Instance;
        public static IProjectFileNameOperator ProjectFileNameOperator { get; } = F0052.ProjectFileNameOperator.Instance;
    }
}