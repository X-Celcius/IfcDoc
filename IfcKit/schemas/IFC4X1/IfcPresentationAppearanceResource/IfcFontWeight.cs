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


namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("bce759cd-c6d9-46b7-a8a9-b61c08dd5f34")]
	public partial struct IfcFontWeight
	{
		[XmlText]
		public String Value;
	
		public IfcFontWeight(String value)
		{
			this.Value = value;
		}
	}
	
}