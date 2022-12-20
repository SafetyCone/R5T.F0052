using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
		public string Classes => "Classes";
		public string Code => "Code";
		public string Components => "Components";
		/// <summary>
		/// Lowercase "css" for front-end CSS files.
		/// </summary>
		public string Css => "css";
		public string Definitions => "Definitions";
		public string Forms => "Forms";
		public string Implementations => "Implementations";
		public string Interfaces => "Interfaces";
		public string Pages => "Pages";
		public string Properties => "Properties";
		public string Services => "Services";
		public string Shared => "Shared";
		/// <summary>
		/// Lowercase "source" for front-end source code files.
		/// </summary>
		public string Source => "source";
		public string StrongTypes => "Strong Types";
		public string Types => "_Types";
		/// <summary>
		/// "wwwroot"
		/// </summary>
		public string WwwRoot => "wwwroot";
	}
}