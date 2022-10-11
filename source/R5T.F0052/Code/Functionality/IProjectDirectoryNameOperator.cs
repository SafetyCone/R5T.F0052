using System;

using R5T.T0132;


namespace R5T.F0052
{
	[FunctionalityMarker]
	public partial interface IProjectDirectoryNameOperator : IFunctionalityMarker
	{
		public string GetProjectDirectoryName_FromProjectName(string projectName)
		{
			// Project directory name is just project name.
			var projectDirectoryName = projectName;
			return projectDirectoryName;
		}
	}
}