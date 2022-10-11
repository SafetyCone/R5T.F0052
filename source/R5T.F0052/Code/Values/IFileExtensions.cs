using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IFileExtensions : IValuesMarker
	{
		public string CSharpProjectFile => "csproj";
	}
}