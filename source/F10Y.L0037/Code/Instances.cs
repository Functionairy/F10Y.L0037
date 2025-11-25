using System;


namespace F10Y.L0037
{
    public static class Instances
    {
        public static L0036.IConventions Conventions => L0036.Conventions.Instance;
        public static IDirectoryNames DirectoryNames => L0037.DirectoryNames.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static IFileExtensions FileExtensions => L0037.FileExtensions.Instance;
        public static IFileSystemOperations FileSystemOperations => L0037.FileSystemOperations.Instance;
        public static IFileSystemOperator FileSystemOperator => L0037.FileSystemOperator.Instance;
        public static L0000.IFileSystemOperator FileSystemOperator_System => L0000.FileSystemOperator.Instance;
        public static L0003.IOverloadTokenOperator OverloadTokenOperator => L0003.OverloadTokenOperator.Instance;
        public static IOverloadTokens OverloadTokens => L0037.OverloadTokens.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
    }
}