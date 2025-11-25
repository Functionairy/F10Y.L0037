using System;

using F10Y.L0003;
using F10Y.L0038;
using F10Y.T0003;


namespace F10Y.L0037
{
    [ValuesMarker]
    public partial interface IOverloadTokens
    {
        IOverloadTokenOperator<ProjectDirectoryPath> ProjectDirectoryPath
            => Instances.OverloadTokenOperator.Of_Type<ProjectDirectoryPath>();

        IOverloadTokenOperator<RepositoriesDirectoryPath> RepositoriesDirectoryPath
            => Instances.OverloadTokenOperator.Of_Type<RepositoriesDirectoryPath>();

        IOverloadTokenOperator<RepositoryDirectoryPath> RepositoryDirectoryPath
            => Instances.OverloadTokenOperator.Of_Type<RepositoryDirectoryPath>();

        IOverloadTokenOperator<SolutionDirectoryPath> SolutionDirectoryPath
            => Instances.OverloadTokenOperator.Of_Type<SolutionDirectoryPath>();

        IOverloadTokenOperator<SolutionsDirectoryPath> SolutionsDirectoryPath
            => Instances.OverloadTokenOperator.Of_Type<SolutionsDirectoryPath>();
    }
}
