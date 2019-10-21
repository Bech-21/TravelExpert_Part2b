﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductSupplier
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TravelExperts")]
	public partial class ProductSuppliersDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProducts_Supplier(Products_Supplier instance);
    partial void UpdateProducts_Supplier(Products_Supplier instance);
    partial void DeleteProducts_Supplier(Products_Supplier instance);
    #endregion
		
		public ProductSuppliersDataContext() : 
				base(global::ProductSupplier.Properties.Settings.Default.TravelExpertsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProductSuppliersDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductSuppliersDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductSuppliersDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductSuppliersDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Products_Supplier> Products_Suppliers
		{
			get
			{
				return this.GetTable<Products_Supplier>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products_Suppliers")]
	public partial class Products_Supplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductSupplierId;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<int> _SupplierId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductSupplierIdChanging(int value);
    partial void OnProductSupplierIdChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnSupplierIdChanging(System.Nullable<int> value);
    partial void OnSupplierIdChanged();
    #endregion
		
		public Products_Supplier()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductSupplierId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductSupplierId
		{
			get
			{
				return this._ProductSupplierId;
			}
			set
			{
				if ((this._ProductSupplierId != value))
				{
					this.OnProductSupplierIdChanging(value);
					this.SendPropertyChanging();
					this._ProductSupplierId = value;
					this.SendPropertyChanged("ProductSupplierId");
					this.OnProductSupplierIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int")]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierId", DbType="Int")]
		public System.Nullable<int> SupplierId
		{
			get
			{
				return this._SupplierId;
			}
			set
			{
				if ((this._SupplierId != value))
				{
					this.OnSupplierIdChanging(value);
					this.SendPropertyChanging();
					this._SupplierId = value;
					this.SendPropertyChanged("SupplierId");
					this.OnSupplierIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
