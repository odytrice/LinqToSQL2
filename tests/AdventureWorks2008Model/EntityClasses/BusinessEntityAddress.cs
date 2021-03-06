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
	/// <summary>Class which represents the entity 'BusinessEntityAddress', mapped on table 'AdventureWorks.Person.BusinessEntityAddress'.</summary>
	public partial class BusinessEntityAddress : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_addressId;
		private System.Int32	_addressTypeId;
		private System.Int32	_businessEntityId;
		private System.DateTime	_modifiedDate;
		private System.Guid	_rowguid;
		private EntityRef <Address> _address;
		private EntityRef <AddressType> _addressType;
		private EntityRef <BusinessEntity> _businessEntity;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnAddressIdChanging(System.Int32 value);
		partial void OnAddressIdChanged();
		partial void OnAddressTypeIdChanging(System.Int32 value);
		partial void OnAddressTypeIdChanged();
		partial void OnBusinessEntityIdChanging(System.Int32 value);
		partial void OnBusinessEntityIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="BusinessEntityAddress"/> class.</summary>
		public BusinessEntityAddress()
		{
			_address = default(EntityRef<Address>);
			_addressType = default(EntityRef<AddressType>);
			_businessEntity = default(EntityRef<BusinessEntity>);
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
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AddressId field. Mapped on target field 'AddressID'. </summary>
		public System.Int32 AddressId
		{
			get	{ return _addressId; }
			set
			{
				if((_addressId != value))
				{
					if(_address.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnAddressIdChanging(value);
					SendPropertyChanging("AddressId");
					_addressId = value;
					SendPropertyChanged("AddressId");
					OnAddressIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the AddressTypeId field. Mapped on target field 'AddressTypeID'. </summary>
		public System.Int32 AddressTypeId
		{
			get	{ return _addressTypeId; }
			set
			{
				if((_addressTypeId != value))
				{
					if(_addressType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnAddressTypeIdChanging(value);
					SendPropertyChanging("AddressTypeId");
					_addressTypeId = value;
					SendPropertyChanged("AddressTypeId");
					OnAddressTypeIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the BusinessEntityId field. Mapped on target field 'BusinessEntityID'. </summary>
		public System.Int32 BusinessEntityId
		{
			get	{ return _businessEntityId; }
			set
			{
				if((_businessEntityId != value))
				{
					if(_businessEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnBusinessEntityIdChanging(value);
					SendPropertyChanging("BusinessEntityId");
					_businessEntityId = value;
					SendPropertyChanged("BusinessEntityId");
					OnBusinessEntityIdChanged();
				}
			}
		}

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

		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.Address - Address.BusinessEntityAddresses (m:1)'</summary>
		public Address Address
		{
			get { return _address.Entity; }
			set
			{
				Address previousValue = _address.Entity;
				if((previousValue != value) || (_address.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Address");
					if(previousValue != null)
					{
						_address.Entity = null;
						previousValue.BusinessEntityAddresses.Remove(this);
					}
					_address.Entity = value;
					if(value == null)
					{
						_addressId = default(System.Int32);
					}
					else
					{
						value.BusinessEntityAddresses.Add(this);
						_addressId = value.Id;
					}
					this.SendPropertyChanged("Address");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.AddressType - AddressType.BusinessEntityAddresses (m:1)'</summary>
		public AddressType AddressType
		{
			get { return _addressType.Entity; }
			set
			{
				AddressType previousValue = _addressType.Entity;
				if((previousValue != value) || (_addressType.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("AddressType");
					if(previousValue != null)
					{
						_addressType.Entity = null;
						previousValue.BusinessEntityAddresses.Remove(this);
					}
					_addressType.Entity = value;
					if(value == null)
					{
						_addressTypeId = default(System.Int32);
					}
					else
					{
						value.BusinessEntityAddresses.Add(this);
						_addressTypeId = value.Id;
					}
					this.SendPropertyChanged("AddressType");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityAddress.BusinessEntity - BusinessEntity.BusinessEntityAddresses (m:1)'</summary>
		public BusinessEntity BusinessEntity
		{
			get { return _businessEntity.Entity; }
			set
			{
				BusinessEntity previousValue = _businessEntity.Entity;
				if((previousValue != value) || (_businessEntity.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("BusinessEntity");
					if(previousValue != null)
					{
						_businessEntity.Entity = null;
						previousValue.BusinessEntityAddresses.Remove(this);
					}
					_businessEntity.Entity = value;
					if(value == null)
					{
						_businessEntityId = default(System.Int32);
					}
					else
					{
						value.BusinessEntityAddresses.Add(this);
						_businessEntityId = value.BusinessEntityId;
					}
					this.SendPropertyChanged("BusinessEntity");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649