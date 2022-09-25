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

namespace InvictusService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="InvictusDatabase")]
	public partial class InvictusDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUserAddress(UserAddress instance);
    partial void UpdateUserAddress(UserAddress instance);
    partial void DeleteUserAddress(UserAddress instance);
    partial void InsertUserPayment(UserPayment instance);
    partial void UpdateUserPayment(UserPayment instance);
    partial void DeleteUserPayment(UserPayment instance);
    partial void InsertProd_Category(Prod_Category instance);
    partial void UpdateProd_Category(Prod_Category instance);
    partial void DeleteProd_Category(Prod_Category instance);
    partial void InsertSystemUser(SystemUser instance);
    partial void UpdateSystemUser(SystemUser instance);
    partial void DeleteSystemUser(SystemUser instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public InvictusDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["InvictusDatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InvictusDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InvictusDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InvictusDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InvictusDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<UserAddress> UserAddresses
		{
			get
			{
				return this.GetTable<UserAddress>();
			}
		}
		
		public System.Data.Linq.Table<UserPayment> UserPayments
		{
			get
			{
				return this.GetTable<UserPayment>();
			}
		}
		
		public System.Data.Linq.Table<Prod_Category> Prod_Categories
		{
			get
			{
				return this.GetTable<Prod_Category>();
			}
		}
		
		public System.Data.Linq.Table<SystemUser> SystemUsers
		{
			get
			{
				return this.GetTable<SystemUser>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserAddress")]
	public partial class UserAddress : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AddressId;
		
		private int _UserID;
		
		private string _AddressCountry;
		
		private string _AdressCity;
		
		private string _AddressPostalCode;
		
		private string _AddressName;
		
		private string _AddressPhoneNumber;
		
		private EntityRef<SystemUser> _SystemUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAddressIdChanging(int value);
    partial void OnAddressIdChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnAddressCountryChanging(string value);
    partial void OnAddressCountryChanged();
    partial void OnAdressCityChanging(string value);
    partial void OnAdressCityChanged();
    partial void OnAddressPostalCodeChanging(string value);
    partial void OnAddressPostalCodeChanged();
    partial void OnAddressNameChanging(string value);
    partial void OnAddressNameChanged();
    partial void OnAddressPhoneNumberChanging(string value);
    partial void OnAddressPhoneNumberChanged();
    #endregion
		
		public UserAddress()
		{
			this._SystemUser = default(EntityRef<SystemUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AddressId
		{
			get
			{
				return this._AddressId;
			}
			set
			{
				if ((this._AddressId != value))
				{
					this.OnAddressIdChanging(value);
					this.SendPropertyChanging();
					this._AddressId = value;
					this.SendPropertyChanged("AddressId");
					this.OnAddressIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._SystemUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressCountry", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AddressCountry
		{
			get
			{
				return this._AddressCountry;
			}
			set
			{
				if ((this._AddressCountry != value))
				{
					this.OnAddressCountryChanging(value);
					this.SendPropertyChanging();
					this._AddressCountry = value;
					this.SendPropertyChanged("AddressCountry");
					this.OnAddressCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdressCity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AdressCity
		{
			get
			{
				return this._AdressCity;
			}
			set
			{
				if ((this._AdressCity != value))
				{
					this.OnAdressCityChanging(value);
					this.SendPropertyChanging();
					this._AdressCity = value;
					this.SendPropertyChanged("AdressCity");
					this.OnAdressCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressPostalCode", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string AddressPostalCode
		{
			get
			{
				return this._AddressPostalCode;
			}
			set
			{
				if ((this._AddressPostalCode != value))
				{
					this.OnAddressPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._AddressPostalCode = value;
					this.SendPropertyChanged("AddressPostalCode");
					this.OnAddressPostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string AddressName
		{
			get
			{
				return this._AddressName;
			}
			set
			{
				if ((this._AddressName != value))
				{
					this.OnAddressNameChanging(value);
					this.SendPropertyChanging();
					this._AddressName = value;
					this.SendPropertyChanged("AddressName");
					this.OnAddressNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressPhoneNumber", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string AddressPhoneNumber
		{
			get
			{
				return this._AddressPhoneNumber;
			}
			set
			{
				if ((this._AddressPhoneNumber != value))
				{
					this.OnAddressPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._AddressPhoneNumber = value;
					this.SendPropertyChanged("AddressPhoneNumber");
					this.OnAddressPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SystemUser_UserAddress", Storage="_SystemUser", ThisKey="UserID", OtherKey="Id", IsForeignKey=true)]
		public SystemUser SystemUser
		{
			get
			{
				return this._SystemUser.Entity;
			}
			set
			{
				SystemUser previousValue = this._SystemUser.Entity;
				if (((previousValue != value) 
							|| (this._SystemUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SystemUser.Entity = null;
						previousValue.UserAddresses.Remove(this);
					}
					this._SystemUser.Entity = value;
					if ((value != null))
					{
						value.UserAddresses.Add(this);
						this._UserID = value.Id;
					}
					else
					{
						this._UserID = default(int);
					}
					this.SendPropertyChanged("SystemUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserPayment")]
	public partial class UserPayment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _User_ID;
		
		private string _Payment_Type;
		
		private string _Provider;
		
		private string _Accounyt_No;
		
		private string _Expiry_Date;
		
		private EntityRef<SystemUser> _SystemUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPayment_TypeChanging(string value);
    partial void OnPayment_TypeChanged();
    partial void OnProviderChanging(string value);
    partial void OnProviderChanged();
    partial void OnAccounyt_NoChanging(string value);
    partial void OnAccounyt_NoChanged();
    partial void OnExpiry_DateChanging(string value);
    partial void OnExpiry_DateChanged();
    #endregion
		
		public UserPayment()
		{
			this._SystemUser = default(EntityRef<SystemUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					if (this._SystemUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Payment_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Payment_Type
		{
			get
			{
				return this._Payment_Type;
			}
			set
			{
				if ((this._Payment_Type != value))
				{
					this.OnPayment_TypeChanging(value);
					this.SendPropertyChanging();
					this._Payment_Type = value;
					this.SendPropertyChanged("Payment_Type");
					this.OnPayment_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Provider", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Provider
		{
			get
			{
				return this._Provider;
			}
			set
			{
				if ((this._Provider != value))
				{
					this.OnProviderChanging(value);
					this.SendPropertyChanging();
					this._Provider = value;
					this.SendPropertyChanged("Provider");
					this.OnProviderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Accounyt_No", DbType="VarChar(16) NOT NULL", CanBeNull=false)]
		public string Accounyt_No
		{
			get
			{
				return this._Accounyt_No;
			}
			set
			{
				if ((this._Accounyt_No != value))
				{
					this.OnAccounyt_NoChanging(value);
					this.SendPropertyChanging();
					this._Accounyt_No = value;
					this.SendPropertyChanged("Accounyt_No");
					this.OnAccounyt_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expiry_Date", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string Expiry_Date
		{
			get
			{
				return this._Expiry_Date;
			}
			set
			{
				if ((this._Expiry_Date != value))
				{
					this.OnExpiry_DateChanging(value);
					this.SendPropertyChanging();
					this._Expiry_Date = value;
					this.SendPropertyChanged("Expiry_Date");
					this.OnExpiry_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SystemUser_UserPayment", Storage="_SystemUser", ThisKey="User_ID", OtherKey="Id", IsForeignKey=true)]
		public SystemUser SystemUser
		{
			get
			{
				return this._SystemUser.Entity;
			}
			set
			{
				SystemUser previousValue = this._SystemUser.Entity;
				if (((previousValue != value) 
							|| (this._SystemUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SystemUser.Entity = null;
						previousValue.UserPayments.Remove(this);
					}
					this._SystemUser.Entity = value;
					if ((value != null))
					{
						value.UserPayments.Add(this);
						this._User_ID = value.Id;
					}
					else
					{
						this._User_ID = default(int);
					}
					this.SendPropertyChanged("SystemUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prod_Category")]
	public partial class Prod_Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CAT_ID;
		
		private string _CAT_Name;
		
		private string _CAT_Desc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCAT_IDChanging(int value);
    partial void OnCAT_IDChanged();
    partial void OnCAT_NameChanging(string value);
    partial void OnCAT_NameChanged();
    partial void OnCAT_DescChanging(string value);
    partial void OnCAT_DescChanged();
    #endregion
		
		public Prod_Category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAT_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CAT_ID
		{
			get
			{
				return this._CAT_ID;
			}
			set
			{
				if ((this._CAT_ID != value))
				{
					this.OnCAT_IDChanging(value);
					this.SendPropertyChanging();
					this._CAT_ID = value;
					this.SendPropertyChanged("CAT_ID");
					this.OnCAT_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAT_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CAT_Name
		{
			get
			{
				return this._CAT_Name;
			}
			set
			{
				if ((this._CAT_Name != value))
				{
					this.OnCAT_NameChanging(value);
					this.SendPropertyChanging();
					this._CAT_Name = value;
					this.SendPropertyChanged("CAT_Name");
					this.OnCAT_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAT_Desc", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CAT_Desc
		{
			get
			{
				return this._CAT_Desc;
			}
			set
			{
				if ((this._CAT_Desc != value))
				{
					this.OnCAT_DescChanging(value);
					this.SendPropertyChanging();
					this._CAT_Desc = value;
					this.SendPropertyChanged("CAT_Desc");
					this.OnCAT_DescChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SystemUser")]
	public partial class SystemUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserSurname;
		
		private string _UserName;
		
		private string _UserIPAddress;
		
		private string _UserEmail;
		
		private string _UserPassword;
		
		private System.Nullable<System.DateTime> _RegDate;
		
		private int _UserStatus;
		
		private string _UserForgotCode;
		
		private System.Nullable<System.DateTime> _UserForgotCodeSentTime;
		
		private string _UserType;
		
		private EntitySet<UserAddress> _UserAddresses;
		
		private EntitySet<UserPayment> _UserPayments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserSurnameChanging(string value);
    partial void OnUserSurnameChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnUserIPAddressChanging(string value);
    partial void OnUserIPAddressChanged();
    partial void OnUserEmailChanging(string value);
    partial void OnUserEmailChanged();
    partial void OnUserPasswordChanging(string value);
    partial void OnUserPasswordChanged();
    partial void OnRegDateChanging(System.Nullable<System.DateTime> value);
    partial void OnRegDateChanged();
    partial void OnUserStatusChanging(int value);
    partial void OnUserStatusChanged();
    partial void OnUserForgotCodeChanging(string value);
    partial void OnUserForgotCodeChanged();
    partial void OnUserForgotCodeSentTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnUserForgotCodeSentTimeChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public SystemUser()
		{
			this._UserAddresses = new EntitySet<UserAddress>(new Action<UserAddress>(this.attach_UserAddresses), new Action<UserAddress>(this.detach_UserAddresses));
			this._UserPayments = new EntitySet<UserPayment>(new Action<UserPayment>(this.attach_UserPayments), new Action<UserPayment>(this.detach_UserPayments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserSurname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserSurname
		{
			get
			{
				return this._UserSurname;
			}
			set
			{
				if ((this._UserSurname != value))
				{
					this.OnUserSurnameChanging(value);
					this.SendPropertyChanging();
					this._UserSurname = value;
					this.SendPropertyChanged("UserSurname");
					this.OnUserSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserIPAddress", DbType="VarChar(50)")]
		public string UserIPAddress
		{
			get
			{
				return this._UserIPAddress;
			}
			set
			{
				if ((this._UserIPAddress != value))
				{
					this.OnUserIPAddressChanging(value);
					this.SendPropertyChanging();
					this._UserIPAddress = value;
					this.SendPropertyChanged("UserIPAddress");
					this.OnUserIPAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserEmail", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string UserEmail
		{
			get
			{
				return this._UserEmail;
			}
			set
			{
				if ((this._UserEmail != value))
				{
					this.OnUserEmailChanging(value);
					this.SendPropertyChanging();
					this._UserEmail = value;
					this.SendPropertyChanged("UserEmail");
					this.OnUserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserPassword
		{
			get
			{
				return this._UserPassword;
			}
			set
			{
				if ((this._UserPassword != value))
				{
					this.OnUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._UserPassword = value;
					this.SendPropertyChanged("UserPassword");
					this.OnUserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegDate", DbType="Date")]
		public System.Nullable<System.DateTime> RegDate
		{
			get
			{
				return this._RegDate;
			}
			set
			{
				if ((this._RegDate != value))
				{
					this.OnRegDateChanging(value);
					this.SendPropertyChanging();
					this._RegDate = value;
					this.SendPropertyChanged("RegDate");
					this.OnRegDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserStatus", DbType="Int NOT NULL")]
		public int UserStatus
		{
			get
			{
				return this._UserStatus;
			}
			set
			{
				if ((this._UserStatus != value))
				{
					this.OnUserStatusChanging(value);
					this.SendPropertyChanging();
					this._UserStatus = value;
					this.SendPropertyChanged("UserStatus");
					this.OnUserStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserForgotCode", DbType="VarChar(250)")]
		public string UserForgotCode
		{
			get
			{
				return this._UserForgotCode;
			}
			set
			{
				if ((this._UserForgotCode != value))
				{
					this.OnUserForgotCodeChanging(value);
					this.SendPropertyChanging();
					this._UserForgotCode = value;
					this.SendPropertyChanged("UserForgotCode");
					this.OnUserForgotCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserForgotCodeSentTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> UserForgotCodeSentTime
		{
			get
			{
				return this._UserForgotCodeSentTime;
			}
			set
			{
				if ((this._UserForgotCodeSentTime != value))
				{
					this.OnUserForgotCodeSentTimeChanging(value);
					this.SendPropertyChanging();
					this._UserForgotCodeSentTime = value;
					this.SendPropertyChanged("UserForgotCodeSentTime");
					this.OnUserForgotCodeSentTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SystemUser_UserAddress", Storage="_UserAddresses", ThisKey="Id", OtherKey="UserID")]
		public EntitySet<UserAddress> UserAddresses
		{
			get
			{
				return this._UserAddresses;
			}
			set
			{
				this._UserAddresses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SystemUser_UserPayment", Storage="_UserPayments", ThisKey="Id", OtherKey="User_ID")]
		public EntitySet<UserPayment> UserPayments
		{
			get
			{
				return this._UserPayments;
			}
			set
			{
				this._UserPayments.Assign(value);
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
		
		private void attach_UserAddresses(UserAddress entity)
		{
			this.SendPropertyChanging();
			entity.SystemUser = this;
		}
		
		private void detach_UserAddresses(UserAddress entity)
		{
			this.SendPropertyChanging();
			entity.SystemUser = null;
		}
		
		private void attach_UserPayments(UserPayment entity)
		{
			this.SendPropertyChanging();
			entity.SystemUser = this;
		}
		
		private void detach_UserPayments(UserPayment entity)
		{
			this.SendPropertyChanging();
			entity.SystemUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Prod_ID;
		
		private string _Prod_Name;
		
		private string _Prod_Image;
		
		private string _Prod_Desciption;
		
		private decimal _Prod_Price;
		
		private int _Prod_Quantity;
		
		private string _Category;
		
		private string _Extra_Image1;
		
		private string _Extra_Image2;
		
		private string _Extra_Image3;
		
		private System.Nullable<decimal> _DISC_DiscPercent;
		
		private int _DISC_Active;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProd_IDChanging(int value);
    partial void OnProd_IDChanged();
    partial void OnProd_NameChanging(string value);
    partial void OnProd_NameChanged();
    partial void OnProd_ImageChanging(string value);
    partial void OnProd_ImageChanged();
    partial void OnProd_DesciptionChanging(string value);
    partial void OnProd_DesciptionChanged();
    partial void OnProd_PriceChanging(decimal value);
    partial void OnProd_PriceChanged();
    partial void OnProd_QuantityChanging(int value);
    partial void OnProd_QuantityChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnExtra_Image1Changing(string value);
    partial void OnExtra_Image1Changed();
    partial void OnExtra_Image2Changing(string value);
    partial void OnExtra_Image2Changed();
    partial void OnExtra_Image3Changing(string value);
    partial void OnExtra_Image3Changed();
    partial void OnDISC_DiscPercentChanging(System.Nullable<decimal> value);
    partial void OnDISC_DiscPercentChanged();
    partial void OnDISC_ActiveChanging(int value);
    partial void OnDISC_ActiveChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Prod_ID
		{
			get
			{
				return this._Prod_ID;
			}
			set
			{
				if ((this._Prod_ID != value))
				{
					this.OnProd_IDChanging(value);
					this.SendPropertyChanging();
					this._Prod_ID = value;
					this.SendPropertyChanged("Prod_ID");
					this.OnProd_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Prod_Name
		{
			get
			{
				return this._Prod_Name;
			}
			set
			{
				if ((this._Prod_Name != value))
				{
					this.OnProd_NameChanging(value);
					this.SendPropertyChanging();
					this._Prod_Name = value;
					this.SendPropertyChanged("Prod_Name");
					this.OnProd_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Image", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Prod_Image
		{
			get
			{
				return this._Prod_Image;
			}
			set
			{
				if ((this._Prod_Image != value))
				{
					this.OnProd_ImageChanging(value);
					this.SendPropertyChanging();
					this._Prod_Image = value;
					this.SendPropertyChanged("Prod_Image");
					this.OnProd_ImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Desciption", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Prod_Desciption
		{
			get
			{
				return this._Prod_Desciption;
			}
			set
			{
				if ((this._Prod_Desciption != value))
				{
					this.OnProd_DesciptionChanging(value);
					this.SendPropertyChanging();
					this._Prod_Desciption = value;
					this.SendPropertyChanged("Prod_Desciption");
					this.OnProd_DesciptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Price", DbType="Money NOT NULL")]
		public decimal Prod_Price
		{
			get
			{
				return this._Prod_Price;
			}
			set
			{
				if ((this._Prod_Price != value))
				{
					this.OnProd_PriceChanging(value);
					this.SendPropertyChanging();
					this._Prod_Price = value;
					this.SendPropertyChanged("Prod_Price");
					this.OnProd_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prod_Quantity", DbType="Int NOT NULL")]
		public int Prod_Quantity
		{
			get
			{
				return this._Prod_Quantity;
			}
			set
			{
				if ((this._Prod_Quantity != value))
				{
					this.OnProd_QuantityChanging(value);
					this.SendPropertyChanging();
					this._Prod_Quantity = value;
					this.SendPropertyChanged("Prod_Quantity");
					this.OnProd_QuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extra_Image1", DbType="VarChar(MAX)")]
		public string Extra_Image1
		{
			get
			{
				return this._Extra_Image1;
			}
			set
			{
				if ((this._Extra_Image1 != value))
				{
					this.OnExtra_Image1Changing(value);
					this.SendPropertyChanging();
					this._Extra_Image1 = value;
					this.SendPropertyChanged("Extra_Image1");
					this.OnExtra_Image1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extra_Image2", DbType="VarChar(MAX)")]
		public string Extra_Image2
		{
			get
			{
				return this._Extra_Image2;
			}
			set
			{
				if ((this._Extra_Image2 != value))
				{
					this.OnExtra_Image2Changing(value);
					this.SendPropertyChanging();
					this._Extra_Image2 = value;
					this.SendPropertyChanged("Extra_Image2");
					this.OnExtra_Image2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Extra_Image3", DbType="VarChar(MAX)")]
		public string Extra_Image3
		{
			get
			{
				return this._Extra_Image3;
			}
			set
			{
				if ((this._Extra_Image3 != value))
				{
					this.OnExtra_Image3Changing(value);
					this.SendPropertyChanging();
					this._Extra_Image3 = value;
					this.SendPropertyChanged("Extra_Image3");
					this.OnExtra_Image3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISC_DiscPercent", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> DISC_DiscPercent
		{
			get
			{
				return this._DISC_DiscPercent;
			}
			set
			{
				if ((this._DISC_DiscPercent != value))
				{
					this.OnDISC_DiscPercentChanging(value);
					this.SendPropertyChanging();
					this._DISC_DiscPercent = value;
					this.SendPropertyChanged("DISC_DiscPercent");
					this.OnDISC_DiscPercentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISC_Active", DbType="Int NOT NULL")]
		public int DISC_Active
		{
			get
			{
				return this._DISC_Active;
			}
			set
			{
				if ((this._DISC_Active != value))
				{
					this.OnDISC_ActiveChanging(value);
					this.SendPropertyChanging();
					this._DISC_Active = value;
					this.SendPropertyChanged("DISC_Active");
					this.OnDISC_ActiveChanged();
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