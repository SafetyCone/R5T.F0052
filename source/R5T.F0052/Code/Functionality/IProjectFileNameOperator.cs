using System;

using R5T.T0132;


namespace R5T.F0052
{
	[FunctionalityMarker]
	public partial interface IProjectFileNameOperator : IFunctionalityMarker
	{
		public string GetProjectFileNameStem_FromProjectName(string projectName)
		{
			// Project file name stem is just the project name.
			var projectFileNameStem = projectName;
			return projectFileNameStem;
		}

		public string GetProjectFileName_FromProjectName(string projectName)
		{
			var projectFileNameStem = this.GetProjectFileNameStem_FromProjectName(projectName);
			var projectFileExtension = Instances.FileExtensions.CSharpProjectFile;

			var output = Instances.FileExtensionOperator.Get_FileName(projectFileNameStem, projectFileExtension);
			return output;
		}
	}
}