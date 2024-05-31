using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
#pragma warning disable IDE1006 // Naming Styles
        private Z0070.Z000.IDirectoryNames _AllOrUndetermined => Z0070.Z000.DirectoryNames.Instance;
        private Z0071.Z002.IDirectoryNames _Common => Z0071.Z002.DirectoryNames.Instance;
        private Z0071.Z000.IDirectoryNames _Common_Raw => Z0071.Z000.DirectoryNames.Instance;
        private Z0073.Z000.IDirectoryNames _Rivet_Raw => Z0073.Z000.DirectoryNames.Instance;
        private Z0072.Z000.IDirectoryNames _Unopinionated_Raw => Z0072.Z000.DirectoryNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Classes"/>
        public string Classes => _Rivet_Raw.Classes;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Code"/>
        public string Code => _Rivet_Raw.Code;

		/// <inheritdoc cref="Z0072.Z000.IDirectoryNames.Components"/>
		public string Components => _Unopinionated_Raw.Components;

        /// <summary>
        /// Lowercase "css" for front-end CSS files.
		/// <para><inheritdoc cref="Z0071.Z000.IDirectoryNames.css" path="descendant::value"/></para>
        /// </summary>
        public string Css => _Common_Raw.css;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Definitions"/>
        public string Definitions => _Rivet_Raw.Definitions;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Forms"/>
        public string Forms => _Rivet_Raw.Forms;

        /// <inheritdoc cref="Z0070.Z000.IDirectoryNames._framework"/>
        public string Framework => _AllOrUndetermined._framework;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Implementations"/>
		public string Implementations => _Rivet_Raw.Implementations;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Interfaces"/>
		public string Interfaces => _Rivet_Raw.Interfaces;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Layouts"/>
        public string Layouts => _Rivet_Raw.Layouts;

        /// <inheritdoc cref="Z0072.Z000.IDirectoryNames.Pages"/>
        public string Pages => _Unopinionated_Raw.Pages;

        /// <inheritdoc cref="Z0072.Z000.IDirectoryNames.Properties"/>
		public string Properties => _Unopinionated_Raw.Properties;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Services"/>
		public string Services => _Rivet_Raw.Services;

        /// <inheritdoc cref="Z0072.Z000.IDirectoryNames.Shared"/>
		public string Shared => _Unopinionated_Raw.Shared;

		/// <inheritdoc cref="Z0071.Z002.IDirectoryNames.FrontEnd_Source_DirectoryName"/>
		public string FrontEnd_Source_DirectoryName => _Common.FrontEnd_Source_DirectoryName;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames.Strong_Types"/>
		public string StrongTypes => _Rivet_Raw.Strong_Types;

        /// <inheritdoc cref="Z0073.Z000.IDirectoryNames._Types"/>
		public string Types => _Rivet_Raw._Types;

        /// <inheritdoc cref="Z0072.Z000.IDirectoryNames.wwwroot"/>
        public string WwwRoot => _Unopinionated_Raw.wwwroot;
	}
}