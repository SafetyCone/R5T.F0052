using System;

using R5T.T0131;


namespace R5T.F0052
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
		public string Code => "Code";
		public string Properties => "Properties";
	}
}