using System;
using System.Runtime.CompilerServices;
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

		public string GetFormsDirectoryPath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var formsDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				codeDirectoryPath,
				Instances.DirectoryNames.Forms);

			return formsDirectoryPath;
		}

		public string GetFormsDirectoryFilePath(
			string projectFilePath,
			string fileName)
		{
			var formsDirectoryPath = this.GetFormsDirectoryPath(projectFilePath);

			var filePath = Instances.PathOperator.GetFilePath(
				formsDirectoryPath,
				fileName);

			return filePath;
		}

		public string GetTypesDirectoryPath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var typesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				codeDirectoryPath,
				Instances.DirectoryNames.Types);

			return typesDirectoryPath;
		}

        public string GetClassesDirectoryPath(string projectFilePath)
        {
            var typesDirectoryPath = this.GetTypesDirectoryPath(projectFilePath);

            var classesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                typesDirectoryPath,
                Instances.DirectoryNames.Classes);

            return classesDirectoryPath;
        }

		public string GetComponentMarkupFilePath(string projectFilePath,
			string componentName)
		{
			var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

			var componentMarkupFileName = $"{componentName}.razor";

			var componentMarkupFilePath = Instances.PathOperator.GetFilePath(
				componentsDirectoryPath,
				componentMarkupFileName);

			return componentMarkupFilePath;
		}

        public string GetComponentCodeBehindFilePath(string projectFilePath,
            string componentName)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var componentCodeBehindFileName = $"{componentName}.razor.cs";

            var componentCodeBehindFilePath = Instances.PathOperator.GetFilePath(
                componentsDirectoryPath,
                componentCodeBehindFileName);

            return componentCodeBehindFilePath;
        }

        public string GetClassCodeFilePath(string projectFilePath,
			string className)
		{
			var classesDirectoryPath = this.GetClassesDirectoryPath(projectFilePath);

            var classFileName = F0053.CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(className);

			var classFilePath = Instances.PathOperator.GetFilePath(
				classesDirectoryPath,
				classFileName);

			return classFilePath;
        }

        public string GetInterfaceCodeFilePath(string projectFilePath,
            string interfaceName)
        {
            var interfacesDirectoryPath = this.GetInterfacesDirectoryPath(projectFilePath);

            var interfaceFileName = F0053.CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(interfaceName);

            var interfaceFilePath = Instances.PathOperator.GetFilePath(
                interfacesDirectoryPath,
                interfaceFileName);

            return interfaceFilePath;
        }

        public string GetInterfacesDirectoryPath(string projectFilePath)
        {
            var typesDirectoryPath = this.GetTypesDirectoryPath(projectFilePath);

			var interfacesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				typesDirectoryPath,
				Instances.DirectoryNames.Interfaces);

            return interfacesDirectoryPath;
        }

        public string GetPagesDirectoryPath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var pagesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.Pages);

            return pagesDirectoryPath;
        }

        public string GetSharedDirectoryPath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var sharedDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.Shared);

            return sharedDirectoryPath;
        }

        public string GetComponentsDirectoryPath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var codeDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.Components);

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

        public string GetTailwindCssFilePath(string projectFilePath)
        {
            var sourceCssDirectoryPath = this.GetSourceCssDirectoryPath(projectFilePath);

            var tailwindCssFilePath = Instances.PathOperator.GetFilePath(
                sourceCssDirectoryPath,
                Instances.FileNames.TailwindCss);

            return tailwindCssFilePath;
        }

        public string GetTailwindContentPathsJsonFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var tailwindContentPathsJsonFilePath = Instances.PathOperator.GetFilePath(
                projectDirectoryPath,
                Instances.FileNames.TailwindContentPathsJson);

            return tailwindContentPathsJsonFilePath;
        }

        public string GetTailwindAllContentPathsJsonFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var tailwindAllContentPathsJsonFilePath = Instances.PathOperator.GetFilePath(
                projectDirectoryPath,
                Instances.FileNames.TailwindAllContentPathsJson);

            return tailwindAllContentPathsJsonFilePath;
        }

        public string GetExampleComponentRazorFilePath(string projectFilePath)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var exampleComponentRazorFilePath = Instances.PathOperator.GetFilePath(componentsDirectoryPath, Instances.FileNames.ExampleComponentRazor);
            return exampleComponentRazorFilePath;
        }

        public string GetIndexRazorFilePath(string projectFilePath)
        {
            var pagesDirectoryPath = this.GetPagesDirectoryPath(projectFilePath);

            var mainLayoutRazorFilePath = Instances.PathOperator.GetFilePath(pagesDirectoryPath, Instances.FileNames.IndexRazor);
            return mainLayoutRazorFilePath;
        }

        public string GetMainLayoutRazorFilePath(string projectFilePath)
        {
            var sharedDirectoryPath = this.GetSharedDirectoryPath(projectFilePath);

            var mainLayoutRazorFilePath = Instances.PathOperator.GetFilePath(sharedDirectoryPath, Instances.FileNames.MainLayout);
            return mainLayoutRazorFilePath;
        }

        public string GetMainImportsRazorFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.GetFilePath(projectDirectoryPath, Instances.FileNames.Imports);
            return instancesFilePath;
        }

        public string GetAppRazorFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.GetFilePath(projectDirectoryPath, Instances.FileNames.AppRazor);
            return instancesFilePath;
        }

        public string GetAppRazorFilePath_InComponents(string projectFilePath)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.GetFilePath(componentsDirectoryPath, Instances.FileNames.AppRazor);
            return instancesFilePath;
        }

        public string GetTailwindConfigJsFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.GetFilePath(projectDirectoryPath, Instances.FileNames.TailwindConfigJs);
            return instancesFilePath;
        }

        public string GetPackageJsonFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.GetFilePath(projectDirectoryPath, Instances.FileNames.PackageJson);
            return instancesFilePath;
        }

        public string GetLaunchSettingsJsonFilePath(string projectFilePath)
		{
			var propertiesDirectoryPath = this.GetPropertiesDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.GetFilePath(propertiesDirectoryPath, Instances.FileNames.LaunchSettingsJson);
			return instancesFilePath;
		}

        public string GetStaticRazorComponentsHostFilePath(string projectFilePath)
        {
            var pagesDirectoryPath = this.GetPagesDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.GetFilePath(pagesDirectoryPath, Instances.FileNames.RazorStaticComponentsHost);
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
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);
			
			var propertiesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				projectDirectoryPath,
				Instances.DirectoryNames.Properties);

			return propertiesDirectoryPath;
		}

		public string GetSourceDirectoryPath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var sourceDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				projectDirectoryPath,
				Instances.DirectoryNames.Source);

			return sourceDirectoryPath;
		}

        public string GetSourceCssDirectoryPath(string projectFilePath)
        {
            var sourceDirectoryPath = this.GetSourceDirectoryPath(projectFilePath);

            var sourceCssDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                sourceDirectoryPath,
                Instances.DirectoryNames.Css);

            return sourceCssDirectoryPath;
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

		public string GetStrongTypesDirectoryPath(string projectFilePath)
		{
            var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

            var strongTypesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                codeDirectoryPath,
                Instances.DirectoryNames.StrongTypes);

			return strongTypesDirectoryPath;
        }

		public string GetStrongTypeCodeFilePath(
			string projectFilePath,
			string strongTypeTypeName)
		{
			var strongTypesDirectoryPath = this.GetStrongTypesDirectoryPath(projectFilePath);

			var strongTypeCodeFileName = F0053.CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(strongTypeTypeName);

			var strongTypeCodeFilePath = Instances.PathOperator.GetFilePath(
				strongTypesDirectoryPath,
				strongTypeCodeFileName);

			return strongTypeCodeFilePath;
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

		public string Get_PlaceholderHtmlFilePath(string projectFilePath)
		{
			var wwwRootDirectoryPath = this.GetWwwRootDirectoryPath(projectFilePath);

			var output = Instances.PathOperator.GetFilePath(
				wwwRootDirectoryPath,
				Instances.FileNames.PlaceholderHtml);

			return output;
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

		public string GetProjectFilePath_FromSolutionDirectoryPath(
			string solutionDirectoryPath,
			string projectName)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath_FromSolutionDirectoryPath(
				solutionDirectoryPath,
				projectName);

			var projectFilePath = this.GetProjectFilePath(
				projectDirectoryPath,
				projectName);

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

		public string GetWwwRootDirectoryPath(string projectFilePath)
		{
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var wwwRootDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.WwwRoot);

            return wwwRootDirectoryPath;
        }

		public string GetWwwRootIndexHtmlFilePath(string projectFilePath)
		{
			var wwwRootDirectoryPath = this.GetWwwRootDirectoryPath(projectFilePath);

            var indexHtmlFilePath = Instances.PathOperator.GetFilePath(
                wwwRootDirectoryPath,
                Instances.FileNames.IndexHtml);

            return indexHtmlFilePath;
        }
	}
}