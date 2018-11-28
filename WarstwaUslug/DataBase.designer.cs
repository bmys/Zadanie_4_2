﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarstwaUslug
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BazaKlientow")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDaneSzczegolne(DaneSzczegolne instance);
    partial void UpdateDaneSzczegolne(DaneSzczegolne instance);
    partial void DeleteDaneSzczegolne(DaneSzczegolne instance);
    partial void InsertKlient(Klient instance);
    partial void UpdateKlient(Klient instance);
    partial void DeleteKlient(Klient instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::WarstwaUslug.Properties.Settings.Default.BazaKlientowConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DaneSzczegolne> DaneSzczegolne
		{
			get
			{
				return this.GetTable<DaneSzczegolne>();
			}
		}
		
		public System.Data.Linq.Table<Klient> Klient
		{
			get
			{
				return this.GetTable<Klient>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DaneSzczegolne")]
	public partial class DaneSzczegolne : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDDanychSzczegolnych;
		
		private System.Nullable<int> _IDKlienta;
		
		private string _Miasto;
		
		private string _Ulica;
		
		private string _NumerMieszkania;
		
		private EntityRef<Klient> _Klient;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDDanychSzczegolnychChanging(int value);
    partial void OnIDDanychSzczegolnychChanged();
    partial void OnIDKlientaChanging(System.Nullable<int> value);
    partial void OnIDKlientaChanged();
    partial void OnMiastoChanging(string value);
    partial void OnMiastoChanged();
    partial void OnUlicaChanging(string value);
    partial void OnUlicaChanged();
    partial void OnNumerMieszkaniaChanging(string value);
    partial void OnNumerMieszkaniaChanged();
    #endregion
		
		public DaneSzczegolne()
		{
			this._Klient = default(EntityRef<Klient>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDanychSzczegolnych", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDDanychSzczegolnych
		{
			get
			{
				return this._IDDanychSzczegolnych;
			}
			set
			{
				if ((this._IDDanychSzczegolnych != value))
				{
					if (this._Klient.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDDanychSzczegolnychChanging(value);
					this.SendPropertyChanging();
					this._IDDanychSzczegolnych = value;
					this.SendPropertyChanged("IDDanychSzczegolnych");
					this.OnIDDanychSzczegolnychChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKlienta", DbType="Int")]
		public System.Nullable<int> IDKlienta
		{
			get
			{
				return this._IDKlienta;
			}
			set
			{
				if ((this._IDKlienta != value))
				{
					this.OnIDKlientaChanging(value);
					this.SendPropertyChanging();
					this._IDKlienta = value;
					this.SendPropertyChanged("IDKlienta");
					this.OnIDKlientaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Miasto", DbType="VarChar(50)")]
		public string Miasto
		{
			get
			{
				return this._Miasto;
			}
			set
			{
				if ((this._Miasto != value))
				{
					this.OnMiastoChanging(value);
					this.SendPropertyChanging();
					this._Miasto = value;
					this.SendPropertyChanged("Miasto");
					this.OnMiastoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ulica", DbType="VarChar(50)")]
		public string Ulica
		{
			get
			{
				return this._Ulica;
			}
			set
			{
				if ((this._Ulica != value))
				{
					this.OnUlicaChanging(value);
					this.SendPropertyChanging();
					this._Ulica = value;
					this.SendPropertyChanged("Ulica");
					this.OnUlicaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumerMieszkania", DbType="VarChar(50)")]
		public string NumerMieszkania
		{
			get
			{
				return this._NumerMieszkania;
			}
			set
			{
				if ((this._NumerMieszkania != value))
				{
					this.OnNumerMieszkaniaChanging(value);
					this.SendPropertyChanging();
					this._NumerMieszkania = value;
					this.SendPropertyChanged("NumerMieszkania");
					this.OnNumerMieszkaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Klient_DaneSzczegolne", Storage="_Klient", ThisKey="IDDanychSzczegolnych", OtherKey="IDKlienta", IsForeignKey=true)]
		public Klient Klient
		{
			get
			{
				return this._Klient.Entity;
			}
			set
			{
				Klient previousValue = this._Klient.Entity;
				if (((previousValue != value) 
							|| (this._Klient.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Klient.Entity = null;
						previousValue.DaneSzczegolne = null;
					}
					this._Klient.Entity = value;
					if ((value != null))
					{
						value.DaneSzczegolne = this;
						this._IDDanychSzczegolnych = value.IDKlienta;
					}
					else
					{
						this._IDDanychSzczegolnych = default(int);
					}
					this.SendPropertyChanged("Klient");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Klient")]
	public partial class Klient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDKlienta;
		
		private string _Imie;
		
		private string _Nazwisko;
		
		private System.Nullable<int> _wiek;
		
		private EntityRef<DaneSzczegolne> _DaneSzczegolne;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDKlientaChanging(int value);
    partial void OnIDKlientaChanged();
    partial void OnImieChanging(string value);
    partial void OnImieChanged();
    partial void OnNazwiskoChanging(string value);
    partial void OnNazwiskoChanged();
    partial void OnwiekChanging(System.Nullable<int> value);
    partial void OnwiekChanged();
    #endregion
		
		public Klient()
		{
			this._DaneSzczegolne = default(EntityRef<DaneSzczegolne>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDKlienta", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDKlienta
		{
			get
			{
				return this._IDKlienta;
			}
			set
			{
				if ((this._IDKlienta != value))
				{
					this.OnIDKlientaChanging(value);
					this.SendPropertyChanging();
					this._IDKlienta = value;
					this.SendPropertyChanged("IDKlienta");
					this.OnIDKlientaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imie", DbType="VarChar(50)")]
		public string Imie
		{
			get
			{
				return this._Imie;
			}
			set
			{
				if ((this._Imie != value))
				{
					this.OnImieChanging(value);
					this.SendPropertyChanging();
					this._Imie = value;
					this.SendPropertyChanged("Imie");
					this.OnImieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazwisko", DbType="VarChar(50)")]
		public string Nazwisko
		{
			get
			{
				return this._Nazwisko;
			}
			set
			{
				if ((this._Nazwisko != value))
				{
					this.OnNazwiskoChanging(value);
					this.SendPropertyChanging();
					this._Nazwisko = value;
					this.SendPropertyChanged("Nazwisko");
					this.OnNazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wiek", DbType="Int")]
		public System.Nullable<int> wiek
		{
			get
			{
				return this._wiek;
			}
			set
			{
				if ((this._wiek != value))
				{
					this.OnwiekChanging(value);
					this.SendPropertyChanging();
					this._wiek = value;
					this.SendPropertyChanged("wiek");
					this.OnwiekChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Klient_DaneSzczegolne", Storage="_DaneSzczegolne", ThisKey="IDKlienta", OtherKey="IDDanychSzczegolnych", IsUnique=true, IsForeignKey=false)]
		public DaneSzczegolne DaneSzczegolne
		{
			get
			{
				return this._DaneSzczegolne.Entity;
			}
			set
			{
				DaneSzczegolne previousValue = this._DaneSzczegolne.Entity;
				if (((previousValue != value) 
							|| (this._DaneSzczegolne.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DaneSzczegolne.Entity = null;
						previousValue.Klient = null;
					}
					this._DaneSzczegolne.Entity = value;
					if ((value != null))
					{
						value.Klient = this;
					}
					this.SendPropertyChanged("DaneSzczegolne");
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