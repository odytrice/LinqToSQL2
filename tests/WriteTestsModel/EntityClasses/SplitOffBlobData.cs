﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace WriteTests.EntityClasses
{
	/// <summary>Class which represents the entity 'SplitOffBlobData', mapped on table 'LLBLGenProUnitTest.dbo.SplitOffTest'.</summary>
	public partial class SplitOffBlobData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_mainDataId;
		private System.String	_notes;
		private System.Data.Linq.Binary	_photo;
		private EntityRef <SplitOffNoBlobData> _mainData;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnMainDataIdChanging(System.Int32 value);
		partial void OnMainDataIdChanged();
		partial void OnNotesChanging(System.String value);
		partial void OnNotesChanged();
		partial void OnPhotoChanging(System.Data.Linq.Binary value);
		partial void OnPhotoChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="SplitOffBlobData"/> class.</summary>
		public SplitOffBlobData()
		{
			_mainData = default(EntityRef<SplitOffNoBlobData>);
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
		/// <summary>Gets or sets the MainDataId field. Mapped on target field 'Id'. </summary>
		public System.Int32 MainDataId
		{
			get	{ return _mainDataId; }
			set
			{
				if((_mainDataId != value))
				{
					if(_mainData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnMainDataIdChanging(value);
					SendPropertyChanging("MainDataId");
					_mainDataId = value;
					SendPropertyChanged("MainDataId");
					OnMainDataIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the Notes field. Mapped on target field 'Notes'. </summary>
		public System.String Notes
		{
			get	{ return _notes; }
			set
			{
				if((_notes != value))
				{
					OnNotesChanging(value);
					SendPropertyChanging("Notes");
					_notes = value;
					SendPropertyChanged("Notes");
					OnNotesChanged();
				}
			}
		}

		/// <summary>Gets or sets the Photo field. Mapped on target field 'Photo'. </summary>
		public System.Data.Linq.Binary Photo
		{
			get	{ return _photo; }
			set
			{
				if((_photo != value))
				{
					OnPhotoChanging(value);
					SendPropertyChanging("Photo");
					_photo = value;
					SendPropertyChanged("Photo");
					OnPhotoChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'SplitOffNoBlobData.BlobData - SplitOffBlobData.MainData (1:1)'</summary>
		public SplitOffNoBlobData MainData
		{
			get { return _mainData.Entity; }
			set
			{
				SplitOffNoBlobData previousValue = _mainData.Entity;
				if((previousValue != value) || (_mainData.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("MainData");
					if(previousValue != null)
					{
						_mainData.Entity = null;
						previousValue.BlobData=null;
					}
					_mainData.Entity = value;
					if(value==null)
					{
						_mainDataId = default(System.Int32);
					}
					else
					{
						value.BlobData = this;
						_mainDataId = value.Id;
					}
					this.SendPropertyChanged("MainData");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649