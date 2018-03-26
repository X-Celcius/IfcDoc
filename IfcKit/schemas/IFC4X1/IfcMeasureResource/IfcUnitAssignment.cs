// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("cdb8d8f7-b0f6-4fc4-a97e-cc6ff85a83f6")]
	public partial class IfcUnitAssignment
	{
		[DataMember(Order=0)] 
		[Required()]
		[MinLength(1)]
		ISet<IfcUnit> _Units = new HashSet<IfcUnit>();
	
	
		public IfcUnitAssignment()
		{
		}
	
		public IfcUnitAssignment(IfcUnit[] __Units)
		{
			this._Units = new HashSet<IfcUnit>(__Units);
		}
	
		[Description("Units to be included within a unit assignment.")]
		public ISet<IfcUnit> Units { get { return this._Units; } }
	
	
	}
	
}