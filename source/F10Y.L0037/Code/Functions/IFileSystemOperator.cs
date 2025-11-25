using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.L0003;
using F10Y.L0036;
using F10Y.L0038;
using F10Y.T0002;


namespace F10Y.L0037
{
    /// <summary>
    /// A file system operator for code files.
    /// </summary>
    [FunctionsMarker]
    public partial interface IFileSystemOperator
    {
        #region Repository Directory Paths

        /// <summary>
        /// The <see cref="IFunctionairy_Convention"/> is that repository directories are the child directories of repositories directories.
        /// </summary>
        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(
            IFunctionairy_Convention convention,
            string repositoriesDirectoryPath,
            OverloadToken_Input<RepositoriesDirectoryPath> repositoriesDirectoryPath_Token)
            => Instances.FileSystemOperator_System.Enumerate_ChildDirectoryPaths(repositoriesDirectoryPath);

        /// <summary>
        /// Chooses <see cref="Enumerate_RepositoryDirectoryPaths(IFunctionairy_Convention, string, OverloadToken_Input{RepositoriesDirectoryPath})"/> as the default.
        /// </summary>
        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(
            string repositoriesDirectoryPath,
            OverloadToken_Input<RepositoriesDirectoryPath> repositoriesDirectoryPath_Token)
            => this.Enumerate_RepositoryDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoriesDirectoryPath,
                repositoriesDirectoryPath_Token);

        /// <summary>
        /// Chooses <see cref="Enumerate_RepositoryDirectoryPaths(IFunctionairy_Convention, string, OverloadToken_Input{RepositoriesDirectoryPath})"/> as the default.
        /// </summary>
        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(
            IFunctionairy_Convention convention,
            string repositoriesDirectoryPath)
            => this.Enumerate_RepositoryDirectoryPaths(
                convention,
                repositoriesDirectoryPath,
                Instances.OverloadTokens.RepositoriesDirectoryPath.Input);

        /// <summary>
        /// Chooses <see cref="Enumerate_RepositoryDirectoryPaths(IFunctionairy_Convention, string, OverloadToken_Input{RepositoriesDirectoryPath})"/> as the default.
        /// </summary>
        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(string repositoriesDirectoryPath)
            => this.Enumerate_RepositoryDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoriesDirectoryPath,
                Instances.OverloadTokens.RepositoriesDirectoryPath.Input);

        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(
            IFunctionairy_Convention convention,
            IEnumerable<string> repositoriesDirectoryPaths)
            => repositoriesDirectoryPaths
                .SelectMany(repositoriesDirectoryPath => this.Enumerate_RepositoryDirectoryPaths(
                    convention,
                    repositoriesDirectoryPath)
                )
                ;

        /// <summary>
        /// Chooses <see cref="Enumerate_RepositoryDirectoryPaths(IFunctionairy_Convention, IEnumerable{string})"/> as the default.
        /// </summary>
        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(IEnumerable<string> repositoriesDirectoryPaths)
            => this.Enumerate_RepositoryDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoriesDirectoryPaths);

        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(
            IFunctionairy_Convention convention,
            params string[] repositoriesDirectoryPaths)
            => this.Enumerate_RepositoryDirectoryPaths(
                convention,
                repositoriesDirectoryPaths.AsEnumerable());

        /// <summary>
        /// Chooses <see cref="Enumerate_RepositoryDirectoryPaths(IFunctionairy_Convention, string[])"/> as the default.
        /// </summary>
        IEnumerable<string> Enumerate_RepositoryDirectoryPaths(params string[] repositoriesDirectoryPaths)
            => this.Enumerate_RepositoryDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoriesDirectoryPaths);

        /// <inheritdoc cref="Enumerate_RepositoryDirectoryPaths(IFunctionairy_Convention, string, OverloadToken_Input{RepositoriesDirectoryPath})"/>
        string[] Get_RepositoryDirectoryPaths(
            IFunctionairy_Convention convention,
            string repositoriesDirectoryPath)
            => this.Enumerate_RepositoryDirectoryPaths(
                convention,
                repositoriesDirectoryPath)
                .ToArray();

        /// <summary>
        /// Chooses <see cref="Get_RepositoryDirectoryPaths(IFunctionairy_Convention, string)"/> as the default.
        /// </summary>
        string[] Get_RepositoryDirectoryPaths(string repositoriesDirectoryPath)
            => this.Get_RepositoryDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoriesDirectoryPath);

        string[] Get_RepositoryDirectoryPaths(
            IFunctionairy_Convention convention,
            IEnumerable<string> repositoriesDirectoryPaths)
            => this.Enumerate_RepositoryDirectoryPaths(
                convention,
                repositoriesDirectoryPaths)
                .ToArray();

        /// <summary>
        /// Chooses <see cref="Get_RepositoryDirectoryPaths(IFunctionairy_Convention, IEnumerable{string})"/> as the default.
        /// </summary>
        string[] Get_RepositoryDirectoryPaths(IEnumerable<string> repositoriesDirectoryPaths)
            => this.Get_RepositoryDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoriesDirectoryPaths);

        string[] Get_RepositoryDirectoryPaths(
            IFunctionairy_Convention convention,
            params string[] repositoriesDirectoryPaths)
            => this.Enumerate_RepositoryDirectoryPaths(
                convention,
                repositoriesDirectoryPaths)
                .ToArray();

        /// <summary>
        /// Chooses <see cref="Get_RepositoryDirectoryPaths(IFunctionairy_Convention, string[])"/> as the default.
        /// </summary>
        string[] Get_RepositoryDirectoryPaths(params string[] repositoriesDirectoryPaths)
            => this.Get_RepositoryDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoriesDirectoryPaths);

        #endregion

        #region Solutions Directory Path

        IEnumerable<string> Enumerate_SolutionsDirectoryPaths(
            IFunctionairy_Convention convention,
            string repositoryDirectoryPath,
            OverloadToken_Input<RepositoryDirectoryPath> repositoryDirectoryPath_Token)
        {
            var source_DirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                repositoryDirectoryPath,
                Instances.DirectoryNames.Source);

            var output = Instances.EnumerableOperator.From(source_DirectoryPath);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="Enumerate_SolutionsDirectoryPaths(IFunctionairy_Convention, string, OverloadToken_Input{RepositoryDirectoryPath})"/> as the default.
        /// </summary>
        IEnumerable<string> Enumerate_SolutionsDirectoryPaths(string repositoryDirectoryPath)
            => this.Enumerate_SolutionsDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoryDirectoryPath,
                Instances.OverloadTokens.RepositoryDirectoryPath.Input);

        IEnumerable<string> Enumerate_SolutionsDirectoryPaths(
            string repositoriesDirectoryPath,
            OverloadToken_Input<RepositoriesDirectoryPath> repositoriesDirectoryPath_Token)
            => this.Enumerate_RepositoryDirectoryPaths(
                repositoriesDirectoryPath,
                repositoriesDirectoryPath_Token)
                .SelectMany(this.Enumerate_SolutionsDirectoryPaths)
                ;

        #endregion

        #region Solution Directory Path

        IEnumerable<string> Enumerate_SolutionDirectoryPaths(
            IFunctionairy_Convention convention,
            string solutionsDirectoryPath,
            OverloadToken_Input<SolutionsDirectoryPath> solutionsDirectoryPath_Token)
            // Solution directory is the same as the solutions directory.
            => Instances.EnumerableOperator.From(solutionsDirectoryPath);

        /// <summary>
        /// Chooses <see cref="Enumerate_SolutionDirectoryPaths(IFunctionairy_Convention, string, OverloadToken_Input{SolutionsDirectoryPath})"/> as the default.
        /// </summary>
        IEnumerable<string> Enumerate_SolutionDirectoryPaths(string solutionsDirectoryPath)
            => this.Enumerate_SolutionDirectoryPaths(
                Instances.Conventions.Functionairy,
                solutionsDirectoryPath,
                Instances.OverloadTokens.SolutionsDirectoryPath.Input);

        IEnumerable<string> Enumerate_SolutionDirectoryPaths(
            string repositoriesDirectoryPath,
            OverloadToken_Input<RepositoriesDirectoryPath> repositoriesDirectoryPath_Token)
            => this.Enumerate_SolutionsDirectoryPaths(
                repositoriesDirectoryPath,
                repositoriesDirectoryPath_Token)
                .SelectMany(this.Enumerate_SolutionDirectoryPaths)
                ;

        #endregion

        #region Project Directory Paths

        IEnumerable<string> Enumerate_ProjectDirectoryPaths(
            IFunctionairy_Convention convention,
            string solutionDirectoryPath,
            OverloadToken_Input<SolutionDirectoryPath> solutionDirectoryPath_Token)
        {
            // Return an sub-directories that contain a C#/.NET project file.
            var output = Instances.FileSystemOperator_System.Enumerate_ChildDirectoryPaths(solutionDirectoryPath)
                .Where(childDirectoryPath => this.Enumerate_ProjectFilePaths(
                    convention,
                    childDirectoryPath,
                    Instances.OverloadTokens.ProjectDirectoryPath.Input)
                    .Any()
                )
                ;

            return output;
        }

        #endregion

        #region Project File Paths

        IEnumerable<string> Enumerate_ProjectFilePaths(
            IFunctionairy_Convention convention,
            string solutionDirectoryPath,
            OverloadToken_Input<SolutionDirectoryPath> solutionDirectoryPath_Token)
        {
            // Return C#/.NET project files in child directories.
            var output = Instances.FileSystemOperator_System.Exists_Directory(solutionDirectoryPath)
                ? Instances.FileSystemOperator_System.Enumerate_ChildDirectoryPaths(solutionDirectoryPath)
                    .SelectMany(childDirectoryPath => this.Enumerate_ProjectFilePaths(
                        convention,
                        childDirectoryPath,
                        Instances.OverloadTokens.ProjectDirectoryPath.Input)
                    )
                : Instances.EnumerableOperator.Empty<string>()
                ;

            return output;
        }

        IEnumerable<string> Enumerate_ProjectFilePaths(
            IFunctionairy_Convention convention,
            string projectDirectoryPath,
            OverloadToken_Input<ProjectDirectoryPath> projectDirectoryPath_Token)
            => Instances.FileSystemOperator_System.Enumerate_ChildFilePaths_ByFileExtension(
                projectDirectoryPath,
                Instances.FileExtensions.csproj);

        IEnumerable<string> Enumerate_ProjectFilePaths(
            string repositoriesDirectoryPath,
            OverloadToken_Input<RepositoriesDirectoryPath> repositoriesDirectoryPath_Token)
            => this.Enumerate_SolutionDirectoryPaths(
                repositoriesDirectoryPath,
                repositoriesDirectoryPath_Token)
                .SelectMany(Instances.FileSystemOperations.Enumerate_ProjectFilePaths(
                    Instances.Conventions.Functionairy,
                    Instances.OverloadTokens.SolutionDirectoryPath.Input)
                )
                ;

        IEnumerable<string> Enumerate_ProjectFilePaths(
            string repositoryDirectoryPath,
            OverloadToken_Input<RepositoryDirectoryPath> repositoryDirectoryPath_Token)
            => this.Enumerate_SolutionsDirectoryPaths(
                Instances.Conventions.Functionairy,
                repositoryDirectoryPath,
                repositoryDirectoryPath_Token)
                .SelectMany(this.Enumerate_SolutionDirectoryPaths)
                .SelectMany(Instances.FileSystemOperations.Enumerate_ProjectFilePaths(
                    Instances.Conventions.Functionairy,
                    Instances.OverloadTokens.SolutionDirectoryPath.Input)
                )
                ;

        string[] Get_ProjectFilePaths(
            OverloadToken_Input<RepositoriesDirectoryPath> repositoriesDirectoryPath_Token,
            IEnumerable<string> repositoriesDirectoryPaths)
            => repositoriesDirectoryPaths
                .SelectMany(repositoriesDirectoryPath => this.Enumerate_ProjectFilePaths(
                    repositoriesDirectoryPath,
                    repositoriesDirectoryPath_Token)
                )
                .ToArray();

        string[] Get_ProjectFilePaths(
            OverloadToken_Input<RepositoriesDirectoryPath> repositoriesDirectoryPath_Token,
            params string[] repositoriesDirectoryPaths)
            => this.Get_ProjectFilePaths(
                repositoriesDirectoryPath_Token,
                repositoriesDirectoryPaths.AsEnumerable());

        string[] Get_ProjectFilePaths(
            OverloadToken_Input<RepositoryDirectoryPath> repositoryDirectoryPath_Token,
            IEnumerable<string> repositoryDirectoryPaths)
            => repositoryDirectoryPaths
                .SelectMany(repositoryDirectoryPath => this.Enumerate_ProjectFilePaths(
                    repositoryDirectoryPath,
                    repositoryDirectoryPath_Token)
                )
                .ToArray();

        string[] Get_ProjectFilePaths(
            OverloadToken_Input<RepositoryDirectoryPath> repositoryDirectoryPath_Token,
            params string[] repositoryDirectoryPaths)
            => this.Get_ProjectFilePaths(
                repositoryDirectoryPath_Token,
                repositoryDirectoryPaths.AsEnumerable());

        #endregion
    }
}
