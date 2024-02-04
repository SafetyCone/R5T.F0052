using System;

using R5T.T0132;


namespace R5T.F0052
{
	[FunctionalityMarker]
	public partial interface IProjectFileNameOperator : IFunctionalityMarker
	{
		public string Get_ProjectFileNameStem_FromProjectName(string projectName)
		{
			// Project file name stem is just the project name.
			var projectFileNameStem = projectName;
			return projectFileNameStem;
		}

		public string Get_ProjectFileName_FromProjectName(string projectName)
		{
			var projectFileNameStem = this.Get_ProjectFileNameStem_FromProjectName(projectName);
			var projectFileExtension = Instances.FileExtensions.CSharpProjectFile;

			var output = Instances.FileExtensionOperator.Get_FileName(projectFileNameStem, projectFileExtension);
			return output;
		}
	}
}