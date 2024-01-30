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

			var instancesFilePath = Instances.PathOperator.Get_FilePath(propertiesDirectoryPath, Instances.FileNames.AppSettingsJson);
			return instancesFilePath;
		}

		public string GetAppSettingsDevelopmentJsonFilePath(string projectFilePath)
		{
			var propertiesDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(propertiesDirectoryPath, Instances.FileNames.AppSettingsDevelopmentJson);
			return instancesFilePath;
		}

		public string GetCodeDirectoryPath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var codeDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				projectDirectoryPath,
				Instances.DirectoryNames.Code);

			return codeDirectoryPath;
		}

		public string GetFormsDirectoryPath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var formsDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				codeDirectoryPath,
				Instances.DirectoryNames.Forms);

			return formsDirectoryPath;
		}

		public string GetFormsDirectoryFilePath(
			string projectFilePath,
			string fileName)
		{
			var formsDirectoryPath = this.GetFormsDirectoryPath(projectFilePath);

			var filePath = Instances.PathOperator.Get_FilePath(
				formsDirectoryPath,
				fileName);

			return filePath;
		}

		public string GetTypesDirectoryPath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var typesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				codeDirectoryPath,
				Instances.DirectoryNames.Types);

			return typesDirectoryPath;
		}

        public string GetClassesDirectoryPath(string projectFilePath)
        {
            var typesDirectoryPath = this.GetTypesDirectoryPath(projectFilePath);

            var classesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                typesDirectoryPath,
                Instances.DirectoryNames.Classes);

            return classesDirectoryPath;
        }

		public string GetComponentMarkupFilePath(string projectFilePath,
			string componentName)
		{
			var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

			var componentMarkupFileName = $"{componentName}.razor";

			var componentMarkupFilePath = Instances.PathOperator.Get_FilePath(
				componentsDirectoryPath,
				componentMarkupFileName);

			return componentMarkupFilePath;
		}

        public string GetComponentCodeBehindFilePath(string projectFilePath,
            string componentName)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var componentCodeBehindFileName = $"{componentName}.razor.cs";

            var componentCodeBehindFilePath = Instances.PathOperator.Get_FilePath(
                componentsDirectoryPath,
                componentCodeBehindFileName);

            return componentCodeBehindFilePath;
        }

        public string GetClassCodeFilePath(string projectFilePath,
			string className)
		{
			var classesDirectoryPath = this.GetClassesDirectoryPath(projectFilePath);

            var classFileName = F0053.CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(className);

			var classFilePath = Instances.PathOperator.Get_FilePath(
				classesDirectoryPath,
				classFileName);

			return classFilePath;
        }

        public string GetInterfaceCodeFilePath(string projectFilePath,
            string interfaceName)
        {
            var interfacesDirectoryPath = this.GetInterfacesDirectoryPath(projectFilePath);

            var interfaceFileName = F0053.CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(interfaceName);

            var interfaceFilePath = Instances.PathOperator.Get_FilePath(
                interfacesDirectoryPath,
                interfaceFileName);

            return interfaceFilePath;
        }

        public string GetInterfacesDirectoryPath(string projectFilePath)
        {
            var typesDirectoryPath = this.GetTypesDirectoryPath(projectFilePath);

			var interfacesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				typesDirectoryPath,
				Instances.DirectoryNames.Interfaces);

            return interfacesDirectoryPath;
        }

        public string GetPagesDirectoryPath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var pagesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.Pages);

            return pagesDirectoryPath;
        }

        public string GetSharedDirectoryPath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var sharedDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.Shared);

            return sharedDirectoryPath;
        }

        public string GetComponentsDirectoryPath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var codeDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.Components);

            return codeDirectoryPath;
        }

        public string Get_ComponentsLayoutsDirectoryPath(string projectFilePath)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var layoutsDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                componentsDirectoryPath,
                Instances.DirectoryNames.Layouts);

            return layoutsDirectoryPath;
        }

        public string GetDocumentationFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var documentationFilePath = Instances.PathOperator.Get_FilePath(
				codeDirectoryPath,
				Instances.FileNames.Documentation);

			return documentationFilePath;
		}

		public string GetInstancesFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(
				codeDirectoryPath,
				Instances.FileNames.Instances);

			return instancesFilePath;
		}

        public string GetTailwindCssFilePath(string projectFilePath)
        {
            var sourceCssDirectoryPath = this.GetSourceCssDirectoryPath(projectFilePath);

            var tailwindCssFilePath = Instances.PathOperator.Get_FilePath(
                sourceCssDirectoryPath,
                Instances.FileNames.TailwindCss);

            return tailwindCssFilePath;
        }

        public string GetTailwindContentPathsJsonFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var tailwindContentPathsJsonFilePath = Instances.PathOperator.Get_FilePath(
                projectDirectoryPath,
                Instances.FileNames.TailwindContentPathsJson);

            return tailwindContentPathsJsonFilePath;
        }

        public string GetTailwindAllContentPathsJsonFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var tailwindAllContentPathsJsonFilePath = Instances.PathOperator.Get_FilePath(
                projectDirectoryPath,
                Instances.FileNames.TailwindAllContentPathsJson);

            return tailwindAllContentPathsJsonFilePath;
        }

        public string GetExampleComponentRazorFilePath(string projectFilePath)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var exampleComponentRazorFilePath = Instances.PathOperator.Get_FilePath(componentsDirectoryPath, Instances.FileNames.ExampleComponentRazor);
            return exampleComponentRazorFilePath;
        }

        public string GetIndexRazorFilePath(string projectFilePath)
        {
            var pagesDirectoryPath = this.GetPagesDirectoryPath(projectFilePath);

            var mainLayoutRazorFilePath = Instances.PathOperator.Get_FilePath(pagesDirectoryPath, Instances.FileNames.IndexRazor);
            return mainLayoutRazorFilePath;
        }

        public string GetMainLayoutRazorFilePath(string projectFilePath)
        {
            var sharedDirectoryPath = this.GetSharedDirectoryPath(projectFilePath);

            var mainLayoutRazorFilePath = Instances.PathOperator.Get_FilePath(sharedDirectoryPath, Instances.FileNames.MainLayout);
            return mainLayoutRazorFilePath;
        }

        public string Get_ComponentsLayoutsLayoutRazorFilePath(string projectFilePath)
        {
            var directoryPath = this.Get_ComponentsLayoutsDirectoryPath(projectFilePath);

            var mainLayoutRazorFilePath = Instances.PathOperator.Get_FilePath(directoryPath, Instances.FileNames.Layout);
            return mainLayoutRazorFilePath;
        }

        public string Get_ComponentsLayoutsLayoutCodeFilePath(string projectFilePath)
        {
            var directoryPath = this.Get_ComponentsLayoutsDirectoryPath(projectFilePath);

			var razorFileName = Instances.FileNames.Layout;
			var razorCodeFileName =  Instances.CodeFileNameOperator.Append_CSharpFileExtension(razorFileName);

            var mainLayoutRazorFilePath = Instances.PathOperator.Get_FilePath(directoryPath, razorCodeFileName);
            return mainLayoutRazorFilePath;
        }

        public string GetMainImportsRazorFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(projectDirectoryPath, Instances.FileNames.Imports);
            return instancesFilePath;
        }

        public string Get_PagesImportsRazorFilePath(string projectFilePath)
        {
            var pagesDirectoryPath = this.GetPagesDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(pagesDirectoryPath, Instances.FileNames.Imports);
            return instancesFilePath;
        }

        public string Get_ComponentsImportsRazorFilePath(string projectFilePath)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(componentsDirectoryPath, Instances.FileNames.Imports);
            return instancesFilePath;
        }

        public string Get_ComponentsLayoutsImportsRazorFilePath(string projectFilePath)
        {
            var componentsLayoutsDirectoryPath = this.Get_ComponentsLayoutsDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(componentsLayoutsDirectoryPath, Instances.FileNames.Imports);
            return instancesFilePath;
        }

        public string GetAppRazorFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(projectDirectoryPath, Instances.FileNames.AppRazor);
            return instancesFilePath;
        }

        public string GetAppRazorFilePath_InComponents(string projectFilePath)
        {
            var componentsDirectoryPath = this.GetComponentsDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(componentsDirectoryPath, Instances.FileNames.AppRazor);
            return instancesFilePath;
        }

        public string GetTailwindConfigJsFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(projectDirectoryPath, Instances.FileNames.TailwindConfigJs);
            return instancesFilePath;
        }

        public string GetPackageJsonFilePath(string projectFilePath)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(projectDirectoryPath, Instances.FileNames.PackageJson);
            return instancesFilePath;
        }

        public string GetLaunchSettingsJsonFilePath(string projectFilePath)
		{
			var propertiesDirectoryPath = this.GetPropertiesDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(propertiesDirectoryPath, Instances.FileNames.LaunchSettingsJson);
			return instancesFilePath;
		}

        public string GetStaticRazorComponentsHostFilePath(string projectFilePath)
        {
            var pagesDirectoryPath = this.GetPagesDirectoryPath(projectFilePath);

            var instancesFilePath = Instances.PathOperator.Get_FilePath(pagesDirectoryPath, Instances.FileNames.RazorStaticComponentsHost);
            return instancesFilePath;
        }

        public string GetProgramFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(codeDirectoryPath, Instances.FileNames.Program);
			return instancesFilePath;
		}

		public string GetProgramEntryPointFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(codeDirectoryPath, Instances.FileNames.ProgramEntryPoint);
			return instancesFilePath;
		}

		public string GetPropertiesDirectoryPath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);
			
			var propertiesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				projectDirectoryPath,
				Instances.DirectoryNames.Properties);

			return propertiesDirectoryPath;
		}

		public string GetSourceDirectoryPath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var sourceDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				projectDirectoryPath,
				Instances.DirectoryNames.Source);

			return sourceDirectoryPath;
		}

        public string GetSourceCssDirectoryPath(string projectFilePath)
        {
            var sourceDirectoryPath = this.GetSourceDirectoryPath(projectFilePath);

            var sourceCssDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                sourceDirectoryPath,
                Instances.DirectoryNames.Css);

            return sourceCssDirectoryPath;
        }

        public string GetServicesDirectoryPath(string projectFilePath)
        {
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var servicesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				codeDirectoryPath,
				Instances.DirectoryNames.Services);

			return servicesDirectoryPath;
		}

		public string GetServiceDefinitionsDirectoryPath(string projectFilePath)
		{
			var servicesDirectoryPath = this.GetServicesDirectoryPath(projectFilePath);

			var serviceDefinitionsDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
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

			var serviceDefinitionFilePath = Instances.PathOperator.Get_FilePath(
				serviceDefinitionsDirectoryPath,
				codeFileName);

			return serviceDefinitionFilePath;
		}

		public string GetServiceImplementationsDirectoryPath(string projectFilePath)
		{
			var servicesDirectoryPath = this.GetServicesDirectoryPath(projectFilePath);

			var serviceImplementationsDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				servicesDirectoryPath,
				Instances.DirectoryNames.Implementations);

			return serviceImplementationsDirectoryPath;
		}

		public string GetServicesConfigurerFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(codeDirectoryPath, Instances.FileNames.ServicesConfigurer);
			return instancesFilePath;
		}

		public string GetStrongTypesDirectoryPath(string projectFilePath)
		{
            var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

            var strongTypesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
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

			var strongTypeCodeFilePath = Instances.PathOperator.Get_FilePath(
				strongTypesDirectoryPath,
				strongTypeCodeFileName);

			return strongTypeCodeFilePath;
		}

		public string GetWebApplicationBuilderConfigurerFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(codeDirectoryPath, Instances.FileNames.WebApplicationBuilderConfigurer);
			return instancesFilePath;
		}

		public string GetWebApplicationConfigurerFilePath(string projectFilePath)
		{
			var codeDirectoryPath = this.GetCodeDirectoryPath(projectFilePath);

			var instancesFilePath = Instances.PathOperator.Get_FilePath(codeDirectoryPath, Instances.FileNames.WebApplicationConfigurer);
			return instancesFilePath;
		}

		public string Get_PlaceholderHtmlFilePath(string projectFilePath)
		{
			var wwwRootDirectoryPath = this.GetWwwRootDirectoryPath(projectFilePath);

			var output = Instances.PathOperator.Get_FilePath(
				wwwRootDirectoryPath,
				Instances.FileNames.PlaceholderHtml);

			return output;
		}

		public string GetProjectFilePath(
			string projectDirectoryPath,
			string projectName)
		{
			var projectFileName = Instances.ProjectFileNameOperator.GetProjectFileName_FromProjectName(projectName);

			var projectFilePath = F0002.Instances.PathOperator.Get_FilePath(
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

			var projectDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				solutionDirectoryPath,
				projectDirectoryName);

			return projectDirectoryPath;
		}

		public string GetProjectPlanTextFilePath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var projectPlanFilePath = Instances.PathOperator.Get_FilePath(
				projectDirectoryPath,
				Instances.FileNames.ProjectPlanTextFile);

			return projectPlanFilePath;
		}

		public string GetProjectPlanMarkdownFilePath(string projectFilePath)
		{
			var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

			var projectPlanFilePath = Instances.PathOperator.Get_FilePath(
				projectDirectoryPath,
				Instances.FileNames.ProjectPlanMarkdownFile);

			return projectPlanFilePath;
		}

		public string GetWwwRootDirectoryPath(string projectFilePath)
		{
            var projectDirectoryPath = this.GetProjectDirectoryPath(projectFilePath);

            var wwwRootDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                projectDirectoryPath,
                Instances.DirectoryNames.WwwRoot);

            return wwwRootDirectoryPath;
        }

		public string GetWwwRootIndexHtmlFilePath(string projectFilePath)
		{
			var wwwRootDirectoryPath = this.GetWwwRootDirectoryPath(projectFilePath);

            var indexHtmlFilePath = Instances.PathOperator.Get_FilePath(
                wwwRootDirectoryPath,
                Instances.FileNames.IndexHtml);

            return indexHtmlFilePath;
        }
	}
}