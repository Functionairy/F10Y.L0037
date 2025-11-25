using System;


namespace F10Y.L0037
{
    public class FileSystemOperations : IFileSystemOperations
    {
        #region Infrastructure

        public static IFileSystemOperations Instance { get; } = new FileSystemOperations();


        private FileSystemOperations()
        {
        }

        #endregion
    }
}
