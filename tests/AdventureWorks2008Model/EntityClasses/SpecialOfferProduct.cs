﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace ReadTestsAdventureWorks2008.EntityClasses
{
	/// <summary>Class which represents the entity 'SpecialOfferProduct', mapped on table 'AdventureWorks.Sales.SpecialOfferProduct'.</summary>
	public partial class SpecialOfferProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.DateTime	_modifiedDate;
		private System.Int32	_productId;
		private System.Guid	_rowguid;
		private System.Int32	_specialOfferId;
		private EntityRef <Product> _product;
		private EntitySet <SalesOrderDetail> _salesOrderDetails;
		private EntityRef <SpecialOffer> _specialOffer;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnProductIdChanging(System.Int32 value);
		partial void OnProductIdChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnSpecialOfferIdChanging(System.Int32 value);
		partial void OnSpecialOfferIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="SpecialOfferProduct"/> class.</summary>
		public SpecialOfferProduct()
		{
			_product = default(EntityRef<Product>);
			_salesOrderDetails = new EntitySet<SalesOrderDetail>(new Action<SalesOrderDetail>(this.Attach_SalesOrderDetails), new Action<SalesOrderDetail>(this.Detach_SalesOrderDetails) );
			_specialOffer = default(EntityRef<SpecialOffer>);
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesOrderDetails(SalesOrderDetail entity)
		{
			this.SendPropertyChanging("SalesOrderDetails");
			entity.SpecialOfferProduct = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesOrderDetails(SalesOrderDetail entity)
		{
			this.SendPropertyChanging("SalesOrderDetails");
			entity.SpecialOfferProduct = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the ProductId field. Mapped on target field 'ProductID'. </summary>
		public System.Int32 ProductId
		{
			get	{ return _productId; }
			set
			{
				if((_productId != value))
				{
					if(_product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnProductIdChanging(value);
					SendPropertyChanging("ProductId");
					_productId = value;
					SendPropertyChanged("ProductId");
					OnProductIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the SpecialOfferId field. Mapped on target field 'SpecialOfferID'. </summary>
		public System.Int32 SpecialOfferId
		{
			get	{ return _specialOfferId; }
			set
			{
				if((_specialOfferId != value))
				{
					if(_specialOffer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnSpecialOfferIdChanging(value);
					SendPropertyChanging("SpecialOfferId");
					_specialOfferId = value;
					SendPropertyChanged("SpecialOfferId");
					OnSpecialOfferIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'SpecialOfferProduct.Product - Product.SpecialOfferProducts (m:1)'</summary>
		public Product Product
		{
			get { return _product.Entity; }
			set
			{
				Product previousValue = _product.Entity;
				if((previousValue != value) || (_product.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Product");
					if(previousValue != null)
					{
						_product.Entity = null;
						previousValue.SpecialOfferProducts.Remove(this);
					}
					_product.Entity = value;
					if(value == null)
					{
						_productId = default(System.Int32);
					}
					else
					{
						value.SpecialOfferProducts.Add(this);
						_productId = value.ProductId;
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderDetail.SpecialOfferProduct - SpecialOfferProduct.SalesOrderDetails (m:1)'</summary>
		public EntitySet<SalesOrderDetail> SalesOrderDetails
		{
			get { return this._salesOrderDetails; }
			set { this._salesOrderDetails.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SpecialOfferProduct.SpecialOffer - SpecialOffer.SpecialOfferProducts (m:1)'</summary>
		public SpecialOffer SpecialOffer
		{
			get { return _specialOffer.Entity; }
			set
			{
				SpecialOffer previousValue = _specialOffer.Entity;
				if((previousValue != value) || (_specialOffer.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("SpecialOffer");
					if(previousValue != null)
					{
						_specialOffer.Entity = null;
						previousValue.SpecialOfferProducts.Remove(this);
					}
					_specialOffer.Entity = value;
					if(value == null)
					{
						_specialOfferId = default(System.Int32);
					}
					else
					{
						value.SpecialOfferProducts.Add(this);
						_specialOfferId = value.SpecialOfferId;
					}
					this.SendPropertyChanged("SpecialOffer");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649