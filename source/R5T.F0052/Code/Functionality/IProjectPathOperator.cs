using System;

using R5T.T0132;


namespace R5T.F0052
{
	[FunctionalityMarker]
	public partial interface IProjectPathOperator : IFunctionalityMarker
	{
		/// <summary>
		/// Determines if the project file path meets the requirements for being a project file path (i.e. ends with the <see cref="F0040.F000.IFileExtensions.CSharpProjectFile"/> project file extension).
		/// NOTE: Does <i>not</i> check if the file exists, or if the file contents meet the requirements of being a project file. Merely checks the path.
		/// To check if the file contents meet the requirements of being a project file, use a project file operator (for example, F5T.F0020.IProjectFileOperator.IsProjectFile()).
		/// </summary>
		public bool IsProjectFilePath(
			string possibleProjectFilePath)
		{
			var isProjectFilePath = Instances.PathOperator.Has_FileExtension(
				possibleProjectFilePath,
				Instances.FileExtensions.CSharpProjectFile);

			return isProjectFilePath;
		}
	}
}