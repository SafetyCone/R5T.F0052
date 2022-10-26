using System;

using R5T.T0132;


namespace R5T.F0052
{
	[FunctionalityMarker]
	public partial interface IProjectPathsOperator : IFunctionalityMarker,
		F0040.F000.IProjectPathsOperator
	{
		public string GetAppSettingsJsonFilePath(string projectFilePath)
		{
			var propertiesDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(propertiesDirectoryPath, Instances.FileNames.AppSettingsJson);
			return instancesFilePath;
		}

		public string GetAppSettingsDevelopmentJsonFilePath(string projectFilePath)
		{
			var propertiesDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(propertiesDirectoryPath, Instances.FileNames.AppSettingsDevelopmentJson);
			return instancesFilePath;
		}

		public string GetCodeDirectoryPath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var codeDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				projectDirectoryPath,
				Instances.DirectoryNames.Code);

			return codeDirectoryPath;
		}

		public string GetDocumentationFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var documentationFilePath = Instances.PathOperator.GetFilePath(
				codeDirectoryPath,
				Instances.FileNames.Documentation);

			return documentationFilePath;
		}

		public string GetInstancesFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(
				codeDirectoryPath,
				Instances.FileNames.Instances);

			return instancesFilePath;
		}

		public string GetLaunchSettingsJsonFilePath(string projectFilePath)
		{
			var propertiesDirectoryPath = this.GetPropertiesDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(propertiesDirectoryPath, Instances.FileNames.LaunchSettingsJson);
			return instancesFilePath;
		}

		public string GetProgramFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(codeDirectoryPath, Instances.FileNames.Program);
			return instancesFilePath;
		}

		public string GetProgramEntryPointFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(codeDirectoryPath, Instances.FileNames.ProgramEntryPoint);
			return instancesFilePath;
		}

		public string GetPropertiesDirectoryPath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);
			
			var propertiesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				codeDirectoryPath,
				Instances.DirectoryNames.Properties);

			return propertiesDirectoryPath;
		}

		public string GetServicesDirectoryPath(string projectFilePath)
        {
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var servicesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				codeDirectoryPath,
				Instances.DirectoryNames.Services);

			return servicesDirectoryPath;
		}

		public string GetServiceDefinitionsDirectoryPath(string projectFilePath)
		{
			var servicesDirectoryPath = this.GetServicesDirectoryPath(projectFilePath);

			var serviceDefinitionsDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				servicesDirectoryPath,
				Instances.DirectoryNames.Definitions);

			return serviceDefinitionsDirectoryPath;
		}

		public string GetServiceDefinitionFilePath(
			string projectFilePath,
			string serviceDefinitionInterfaceTypeName)
		{
			var serviceDefinitionsDirectoryPath = this.GetServiceDefinitionsDirectoryPath(projectFilePath);

			var codeFileName = F0053.CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(serviceDefinitionInterfaceTypeName);

			var serviceDefinitionFilePath = Instances.PathOperator.GetFilePath(
				serviceDefinitionsDirectoryPath,
				codeFileName);

			return serviceDefinitionFilePath;
		}

		public string GetServiceImplementationsDirectoryPath(string projectFilePath)
		{
			var servicesDirectoryPath = this.GetServicesDirectoryPath(projectFilePath);

			var serviceImplementationsDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				servicesDirectoryPath,
				Instances.DirectoryNames.Implementations);

			return serviceImplementationsDirectoryPath;
		}

		public string GetServicesConfigurerFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(codeDirectoryPath, Instances.FileNames.ServicesConfigurer);
			return instancesFilePath;
		}

		public string GetWebApplicationBuilderConfigurerFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(codeDirectoryPath, Instances.FileNames.WebApplicationBuilderConfigurer);
			return instancesFilePath;
		}

		public string GetWebApplicationConfigurerFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(codeDirectoryPath, Instances.FileNames.WebApplicationConfigurer);
			return instancesFilePath;
		}

		public string GetProjectFilePath(
			string projectDirectoryPath,
			string projectName)
		{
			var projectFileName = Instances.ProjectFileNameOperator.GetProjectFileName_FromProjectName(projectName);

			var projectFilePath = F0002.Instances.PathOperator.GetFilePath(
				projectDirectoryPath,
				projectFileName);

			return projectFilePath;
		}

		public string GetProjectDirectoryPath_FromSolutionDirectoryPath(
			string solutionDirectoryPath,
			string projectName)
		{
			var projectDirectoryName = Instances.ProjectDirectoryNameOperator.GetProjectDirectoryName_FromProjectName(projectName);

			var projectDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				solutionDirectoryPath,
				projectDirectoryName);

			return projectDirectoryPath;
		}

		public string GetProjectPlanTextFilePath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var projectPlanFilePath = Instances.PathOperator.GetFilePath(
				projectDirectoryPath,
				Instances.FileNames.ProjectPlanTextFile);

			return projectPlanFilePath;
		}

		public string GetProjectPlanMarkdownFilePath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var projectPlanFilePath = Instances.PathOperator.GetFilePath(
				projectDirectoryPath,
				Instances.FileNames.ProjectPlanMarkdownFile);

			return projectPlanFilePath;
		}
	}
}