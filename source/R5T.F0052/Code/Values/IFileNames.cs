using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IFileNames : IValuesMarker
	{
		public string AppSettingsJson => "appSettings.json";
		public string AppSettingsDevelopmentJson => "appSettings.Development.json";
		public string Documentation => "Documentation.cs";
		public string Instances => "Instances.cs";
		public string LaunchSettingsJson => "launchSettings.json";
		public string Program => "Program.cs";
		public string ProgramEntryPoint => "Program-Entry Point.cs";
		public string ProjectPlanTextFile => "Project Plan.txt";
		public string ProjectPlanMarkdownFile => "Project Plan.md";
		public string ServicesConfigurer => "ServicesConfigurer.cs";
		public string WebApplicationBuilderConfigurer => "WebApplicationBuilderConfigurer.cs";
		public string WebApplicationConfigurer => "WebApplicationConfigurer.cs";
	}
}