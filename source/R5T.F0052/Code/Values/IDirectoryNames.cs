using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
		public string Code => "Code";
		public string Definitions => "Definitions";
		public string Implementations => "Implementations";
		public string Properties => "Properties";
		public string Services => "Services";
	}
}