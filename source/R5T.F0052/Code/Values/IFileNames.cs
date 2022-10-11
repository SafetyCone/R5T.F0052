using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IFileNames : IValuesMarker
	{
		public string Documentation => "Documentation.cs";
		public string Instances => "Instances.cs";
		public string Program => "Program.cs";
		public string ProjectPlanTextFile => "Project Plan.txt";
		public string ProjectPlanMarkdownFile => "Project Plan.md";
	}
}