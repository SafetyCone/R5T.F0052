using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IFileNames : IValuesMarker
	{
		public string AppRazor => "App.razor";
		public string AppSettingsJson => "appSettings.json";
		public string AppSettingsDevelopmentJson => "appSettings.Development.json";
		public string Documentation => "Documentation.cs";
		public string Imports => "_Imports.razor";
		/// <summary>
		/// Lowercase "index.html" for the client-side.
		/// </summary>
		public string IndexHtml => "index.html";
		public string IndexRazor => "Index.razor";
		public string Instances => "Instances.cs";
		public string LaunchSettingsJson => "launchSettings.json";
		public string MainLayout => "MainLayout.razor";
		/// <summary>
		/// NPM package.json file.
		/// </summary>
        public string PackageJson => "package.json";
        public string Program => "Program.cs";
		public string ProgramEntryPoint => "Program-Entry Point.cs";
		public string ProjectPlanTextFile => "Project Plan.txt";
		public string ProjectPlanMarkdownFile => "Project Plan.md";
		public string ServicesConfigurer => "ServicesConfigurer.cs";
        public string TailwindConfigJs => "tailwind.config.cs";
		public string TailwindCss => "tailwind.css";
        public string WebApplicationBuilderConfigurer => "WebApplicationBuilderConfigurer.cs";
		public string WebApplicationConfigurer => "WebApplicationConfigurer.cs";
	}
}