// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0-snapshot1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// This resource reflects an instance of a biologically derived product
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("BiologicallyDerivedProduct","http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct", IsResource=true)]
  public partial class BiologicallyDerivedProduct : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "BiologicallyDerivedProduct"; } }

    /// <summary>
    /// Biologically Derived Product Category.
    /// (url: http://hl7.org/fhir/ValueSet/product-category)
    /// (system: http://hl7.org/fhir/product-category)
    /// </summary>
    [FhirEnumeration("BiologicallyDerivedProductCategory")]
    public enum BiologicallyDerivedProductCategory
    {
      /// <summary>
      /// A collection of tissues joined in a structural unit to serve a common function.
      /// (system: http://hl7.org/fhir/product-category)
      /// </summary>
      [EnumLiteral("organ", "http://hl7.org/fhir/product-category"), Description("Organ")]
      Organ,
      /// <summary>
      /// An ensemble of similar cells and their extracellular matrix from the same origin that together carry out a specific function.
      /// (system: http://hl7.org/fhir/product-category)
      /// </summary>
      [EnumLiteral("tissue", "http://hl7.org/fhir/product-category"), Description("Tissue")]
      Tissue,
      /// <summary>
      /// Body fluid.
      /// (system: http://hl7.org/fhir/product-category)
      /// </summary>
      [EnumLiteral("fluid", "http://hl7.org/fhir/product-category"), Description("Fluid")]
      Fluid,
      /// <summary>
      /// Collection of cells.
      /// (system: http://hl7.org/fhir/product-category)
      /// </summary>
      [EnumLiteral("cells", "http://hl7.org/fhir/product-category"), Description("Cells")]
      Cells,
      /// <summary>
      /// Biological agent of unspecified type.
      /// (system: http://hl7.org/fhir/product-category)
      /// </summary>
      [EnumLiteral("biologicalAgent", "http://hl7.org/fhir/product-category"), Description("BiologicalAgent")]
      BiologicalAgent,
    }

    /// <summary>
    /// Biologically Derived Product Status.
    /// (url: http://hl7.org/fhir/ValueSet/biological-product-status)
    /// (system: http://hl7.org/fhir/biological-product-status)
    /// </summary>
    [FhirEnumeration("BiologicallyDerivedProductStatus")]
    public enum BiologicallyDerivedProductStatus
    {
      /// <summary>
      /// Product is currently available for use.
      /// (system: http://hl7.org/fhir/biological-product-status)
      /// </summary>
      [EnumLiteral("available", "http://hl7.org/fhir/biological-product-status"), Description("Available")]
      Available,
      /// <summary>
      /// Product is not currently available for use.
      /// (system: http://hl7.org/fhir/biological-product-status)
      /// </summary>
      [EnumLiteral("unavailable", "http://hl7.org/fhir/biological-product-status"), Description("Unavailable")]
      Unavailable,
    }

    /// <summary>
    /// How this product was collected
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("BiologicallyDerivedProduct#Collection", IsNestedType=true)]
    public partial class CollectionComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "BiologicallyDerivedProduct#Collection"; } }

      /// <summary>
      /// Individual performing collection
      /// </summary>
      [FhirElement("collector", Order=40)]
      [CLSCompliant(false)]
      [References("Practitioner","PractitionerRole")]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Collector
      {
        get { return _Collector; }
        set { _Collector = value; OnPropertyChanged("Collector"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Collector;

      /// <summary>
      /// Who is product from
      /// </summary>
      [FhirElement("source", Order=50)]
      [CLSCompliant(false)]
      [References("Patient","Organization")]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Source
      {
        get { return _Source; }
        set { _Source = value; OnPropertyChanged("Source"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Source;

      /// <summary>
      /// Time of product collection
      /// </summary>
      [FhirElement("collected", Order=60, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Collected
      {
        get { return _Collected; }
        set { _Collected = value; OnPropertyChanged("Collected"); }
      }

      private Hl7.Fhir.Model.DataType _Collected;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as CollectionComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Collector != null) dest.Collector = (Hl7.Fhir.Model.ResourceReference)Collector.DeepCopy();
        if(Source != null) dest.Source = (Hl7.Fhir.Model.ResourceReference)Source.DeepCopy();
        if(Collected != null) dest.Collected = (Hl7.Fhir.Model.DataType)Collected.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new CollectionComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as CollectionComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Collector, otherT.Collector)) return false;
        if( !DeepComparable.Matches(Source, otherT.Source)) return false;
        if( !DeepComparable.Matches(Collected, otherT.Collected)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as CollectionComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Collector, otherT.Collector)) return false;
        if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
        if( !DeepComparable.IsExactly(Collected, otherT.Collected)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Collector != null) yield return Collector;
          if (Source != null) yield return Source;
          if (Collected != null) yield return Collected;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Collector != null) yield return new ElementValue("collector", Collector);
          if (Source != null) yield return new ElementValue("source", Source);
          if (Collected != null) yield return new ElementValue("collected", Collected);
        }
      }

    }

    /// <summary>
    /// A property that is specific to this BiologicallyDerviedProduct instance
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("BiologicallyDerivedProduct#Property", IsNestedType=true)]
    public partial class PropertyComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "BiologicallyDerivedProduct#Property"; } }

      /// <summary>
      /// Code that specifies the property
      /// </summary>
      [FhirElement("type", Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      /// <summary>
      /// Property values
      /// </summary>
      [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Integer),typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.Quantity),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.Attachment))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.DataType _Value;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PropertyComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.DataType)Value.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PropertyComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Type != null) yield return Type;
          if (Value != null) yield return Value;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Type != null) yield return new ElementValue("type", Type);
          if (Value != null) yield return new ElementValue("value", Value);
        }
      }

    }

    /// <summary>
    /// organ | tissue | fluid | cells | biologicalAgent
    /// </summary>
    [FhirElement("productCategory", Order=90)]
    [DeclaredType(Type = typeof(Code))]
    [DataMember]
    public Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> ProductCategoryElement
    {
      get { return _ProductCategoryElement; }
      set { _ProductCategoryElement = value; OnPropertyChanged("ProductCategoryElement"); }
    }

    private Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> _ProductCategoryElement;

    /// <summary>
    /// organ | tissue | fluid | cells | biologicalAgent
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? ProductCategory
    {
      get { return ProductCategoryElement != null ? ProductCategoryElement.Value : null; }
      set
      {
        if (value == null)
          ProductCategoryElement = null;
        else
          ProductCategoryElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>(value);
        OnPropertyChanged("ProductCategory");
      }
    }

    /// <summary>
    /// What this biologically derived product is
    /// </summary>
    [FhirElement("productCode", Order=100)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept ProductCode
    {
      get { return _ProductCode; }
      set { _ProductCode = value; OnPropertyChanged("ProductCode"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _ProductCode;

    /// <summary>
    /// BiologicallyDerivedProduct parent
    /// </summary>
    [FhirElement("parent", Order=110)]
    [CLSCompliant(false)]
    [References("BiologicallyDerivedProduct")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Parent
    {
      get { if(_Parent==null) _Parent = new List<Hl7.Fhir.Model.ResourceReference>(); return _Parent; }
      set { _Parent = value; OnPropertyChanged("Parent"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Parent;

    /// <summary>
    /// Procedure request
    /// </summary>
    [FhirElement("request", Order=120)]
    [CLSCompliant(false)]
    [References("ServiceRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Request
    {
      get { if(_Request==null) _Request = new List<Hl7.Fhir.Model.ResourceReference>(); return _Request; }
      set { _Request = value; OnPropertyChanged("Request"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Request;

    /// <summary>
    /// External ids for this item
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=130)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// An identifier that supports traceability to the biological entity that is the source of biological material in the product
    /// </summary>
    [FhirElement("biologicalSource", InSummary=true, Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.Identifier BiologicalSource
    {
      get { return _BiologicalSource; }
      set { _BiologicalSource = value; OnPropertyChanged("BiologicalSource"); }
    }

    private Hl7.Fhir.Model.Identifier _BiologicalSource;

    /// <summary>
    /// Processing facility
    /// </summary>
    [FhirElement("processingFacility", Order=150)]
    [CLSCompliant(false)]
    [References("Organization")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ProcessingFacility
    {
      get { if(_ProcessingFacility==null) _ProcessingFacility = new List<Hl7.Fhir.Model.ResourceReference>(); return _ProcessingFacility; }
      set { _ProcessingFacility = value; OnPropertyChanged("ProcessingFacility"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ProcessingFacility;

    /// <summary>
    /// Description of division
    /// </summary>
    [FhirElement("division", Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DivisionElement
    {
      get { return _DivisionElement; }
      set { _DivisionElement = value; OnPropertyChanged("DivisionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DivisionElement;

    /// <summary>
    /// Description of division
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Division
    {
      get { return DivisionElement != null ? DivisionElement.Value : null; }
      set
      {
        if (value == null)
          DivisionElement = null;
        else
          DivisionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Division");
      }
    }

    /// <summary>
    /// available | unavailable
    /// </summary>
    [FhirElement("status", Order=170)]
    [DeclaredType(Type = typeof(Code))]
    [DataMember]
    public Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> _StatusElement;

    /// <summary>
    /// available | unavailable
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Date of expiration
    /// </summary>
    [FhirElement("expirationDate", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime ExpirationDateElement
    {
      get { return _ExpirationDateElement; }
      set { _ExpirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _ExpirationDateElement;

    /// <summary>
    /// Date of expiration
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string ExpirationDate
    {
      get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
      set
      {
        if (value == null)
          ExpirationDateElement = null;
        else
          ExpirationDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("ExpirationDate");
      }
    }

    /// <summary>
    /// How this product was collected
    /// </summary>
    [FhirElement("collection", Order=190)]
    [DataMember]
    public Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent Collection
    {
      get { return _Collection; }
      set { _Collection = value; OnPropertyChanged("Collection"); }
    }

    private Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent _Collection;

    /// <summary>
    /// Product storage temp requirements
    /// </summary>
    [FhirElement("storageTempRequirements", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.Range StorageTempRequirements
    {
      get { return _StorageTempRequirements; }
      set { _StorageTempRequirements = value; OnPropertyChanged("StorageTempRequirements"); }
    }

    private Hl7.Fhir.Model.Range _StorageTempRequirements;

    /// <summary>
    /// A property that is specific to this BiologicallyDerviedProduct instance
    /// </summary>
    [FhirElement("property", Order=210)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent> Property
    {
      get { if(_Property==null) _Property = new List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent>(); return _Property; }
      set { _Property = value; OnPropertyChanged("Property"); }
    }

    private List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent> _Property;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as BiologicallyDerivedProduct;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(ProductCategoryElement != null) dest.ProductCategoryElement = (Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>)ProductCategoryElement.DeepCopy();
      if(ProductCode != null) dest.ProductCode = (Hl7.Fhir.Model.CodeableConcept)ProductCode.DeepCopy();
      if(Parent != null) dest.Parent = new List<Hl7.Fhir.Model.ResourceReference>(Parent.DeepCopy());
      if(Request != null) dest.Request = new List<Hl7.Fhir.Model.ResourceReference>(Request.DeepCopy());
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BiologicalSource != null) dest.BiologicalSource = (Hl7.Fhir.Model.Identifier)BiologicalSource.DeepCopy();
      if(ProcessingFacility != null) dest.ProcessingFacility = new List<Hl7.Fhir.Model.ResourceReference>(ProcessingFacility.DeepCopy());
      if(DivisionElement != null) dest.DivisionElement = (Hl7.Fhir.Model.FhirString)DivisionElement.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>)StatusElement.DeepCopy();
      if(ExpirationDateElement != null) dest.ExpirationDateElement = (Hl7.Fhir.Model.FhirDateTime)ExpirationDateElement.DeepCopy();
      if(Collection != null) dest.Collection = (Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent)Collection.DeepCopy();
      if(StorageTempRequirements != null) dest.StorageTempRequirements = (Hl7.Fhir.Model.Range)StorageTempRequirements.DeepCopy();
      if(Property != null) dest.Property = new List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent>(Property.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new BiologicallyDerivedProduct());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as BiologicallyDerivedProduct;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(ProductCategoryElement, otherT.ProductCategoryElement)) return false;
      if( !DeepComparable.Matches(ProductCode, otherT.ProductCode)) return false;
      if( !DeepComparable.Matches(Parent, otherT.Parent)) return false;
      if( !DeepComparable.Matches(Request, otherT.Request)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BiologicalSource, otherT.BiologicalSource)) return false;
      if( !DeepComparable.Matches(ProcessingFacility, otherT.ProcessingFacility)) return false;
      if( !DeepComparable.Matches(DivisionElement, otherT.DivisionElement)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
      if( !DeepComparable.Matches(Collection, otherT.Collection)) return false;
      if( !DeepComparable.Matches(StorageTempRequirements, otherT.StorageTempRequirements)) return false;
      if( !DeepComparable.Matches(Property, otherT.Property)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as BiologicallyDerivedProduct;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(ProductCategoryElement, otherT.ProductCategoryElement)) return false;
      if( !DeepComparable.IsExactly(ProductCode, otherT.ProductCode)) return false;
      if( !DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
      if( !DeepComparable.IsExactly(Request, otherT.Request)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BiologicalSource, otherT.BiologicalSource)) return false;
      if( !DeepComparable.IsExactly(ProcessingFacility, otherT.ProcessingFacility)) return false;
      if( !DeepComparable.IsExactly(DivisionElement, otherT.DivisionElement)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
      if( !DeepComparable.IsExactly(Collection, otherT.Collection)) return false;
      if( !DeepComparable.IsExactly(StorageTempRequirements, otherT.StorageTempRequirements)) return false;
      if( !DeepComparable.IsExactly(Property, otherT.Property)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (ProductCategoryElement != null) yield return ProductCategoryElement;
        if (ProductCode != null) yield return ProductCode;
        foreach (var elem in Parent) { if (elem != null) yield return elem; }
        foreach (var elem in Request) { if (elem != null) yield return elem; }
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (BiologicalSource != null) yield return BiologicalSource;
        foreach (var elem in ProcessingFacility) { if (elem != null) yield return elem; }
        if (DivisionElement != null) yield return DivisionElement;
        if (StatusElement != null) yield return StatusElement;
        if (ExpirationDateElement != null) yield return ExpirationDateElement;
        if (Collection != null) yield return Collection;
        if (StorageTempRequirements != null) yield return StorageTempRequirements;
        foreach (var elem in Property) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (ProductCategoryElement != null) yield return new ElementValue("productCategory", ProductCategoryElement);
        if (ProductCode != null) yield return new ElementValue("productCode", ProductCode);
        foreach (var elem in Parent) { if (elem != null) yield return new ElementValue("parent", elem); }
        foreach (var elem in Request) { if (elem != null) yield return new ElementValue("request", elem); }
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (BiologicalSource != null) yield return new ElementValue("biologicalSource", BiologicalSource);
        foreach (var elem in ProcessingFacility) { if (elem != null) yield return new ElementValue("processingFacility", elem); }
        if (DivisionElement != null) yield return new ElementValue("division", DivisionElement);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
        if (Collection != null) yield return new ElementValue("collection", Collection);
        if (StorageTempRequirements != null) yield return new ElementValue("storageTempRequirements", StorageTempRequirements);
        foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
      }
    }

  }

}

// end of file
