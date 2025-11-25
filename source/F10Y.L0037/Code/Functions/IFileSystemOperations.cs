using System;
using System.Collections.Generic;

using F10Y.L0003;
using F10Y.L0036;
using F10Y.L0038;
using F10Y.T0002;



namespace F10Y.L0037
{
    [FunctionsMarker]
    public partial interface IFileSystemOperations
    {
        #region Project File Paths

        public Func<string, IEnumerable<string>> Enumerate_ProjectFilePaths(
           IFunctionairy_Convention convention,
           OverloadToken_Input<SolutionDirectoryPath> solutionDirectoryPath_Token)
           => solutionDirectoryPath => Instances.FileSystemOperator.Enumerate_ProjectFilePaths(
               convention,
               solutionDirectoryPath,
               solutionDirectoryPath_Token);

        #endregion
    }
}
