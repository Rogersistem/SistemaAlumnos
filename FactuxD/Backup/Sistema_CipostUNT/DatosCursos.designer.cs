﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FactuxD
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBA_CIPOST2019")]
	public partial class DatosCursosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCurso(Curso instance);
    partial void UpdateCurso(Curso instance);
    partial void DeleteCurso(Curso instance);
    #endregion
		
		public DatosCursosDataContext() : 
				base(global::FactuxD.Properties.Settings.Default.DBA_CIPOST2019ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatosCursosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosCursosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosCursosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosCursosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Curso> Curso
		{
			get
			{
				return this.GetTable<Curso>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SpMantCursos")]
		public ISingleResult<SpMantCursosResult> SpMantCursos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SpMantCursosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SPultimoCurso")]
		public ISingleResult<SPultimoCursoResult> SPultimoCurso()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SPultimoCursoResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Curso")]
	public partial class Curso : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _codCurso;
		
		private string _CurNomcurso;
		
		private string _codPrograma;
		
		private string _docCodigo;
		
		private string _years;
		
		private string _aula;
		
		private string _horaInicio;
		
		private string _horaTerminno;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodCursoChanging(string value);
    partial void OncodCursoChanged();
    partial void OnCurNomcursoChanging(string value);
    partial void OnCurNomcursoChanged();
    partial void OncodProgramaChanging(string value);
    partial void OncodProgramaChanged();
    partial void OndocCodigoChanging(string value);
    partial void OndocCodigoChanged();
    partial void OnyearsChanging(string value);
    partial void OnyearsChanged();
    partial void OnaulaChanging(string value);
    partial void OnaulaChanged();
    partial void OnhoraInicioChanging(string value);
    partial void OnhoraInicioChanged();
    partial void OnhoraTerminnoChanging(string value);
    partial void OnhoraTerminnoChanged();
    #endregion
		
		public Curso()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codCurso", DbType="Char(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string codCurso
		{
			get
			{
				return this._codCurso;
			}
			set
			{
				if ((this._codCurso != value))
				{
					this.OncodCursoChanging(value);
					this.SendPropertyChanging();
					this._codCurso = value;
					this.SendPropertyChanged("codCurso");
					this.OncodCursoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurNomcurso", DbType="VarChar(30)")]
		public string CurNomcurso
		{
			get
			{
				return this._CurNomcurso;
			}
			set
			{
				if ((this._CurNomcurso != value))
				{
					this.OnCurNomcursoChanging(value);
					this.SendPropertyChanging();
					this._CurNomcurso = value;
					this.SendPropertyChanged("CurNomcurso");
					this.OnCurNomcursoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codPrograma", DbType="Char(9)")]
		public string codPrograma
		{
			get
			{
				return this._codPrograma;
			}
			set
			{
				if ((this._codPrograma != value))
				{
					this.OncodProgramaChanging(value);
					this.SendPropertyChanging();
					this._codPrograma = value;
					this.SendPropertyChanged("codPrograma");
					this.OncodProgramaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_docCodigo", DbType="Char(9)")]
		public string docCodigo
		{
			get
			{
				return this._docCodigo;
			}
			set
			{
				if ((this._docCodigo != value))
				{
					this.OndocCodigoChanging(value);
					this.SendPropertyChanging();
					this._docCodigo = value;
					this.SendPropertyChanged("docCodigo");
					this.OndocCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_years", DbType="Char(9)")]
		public string years
		{
			get
			{
				return this._years;
			}
			set
			{
				if ((this._years != value))
				{
					this.OnyearsChanging(value);
					this.SendPropertyChanging();
					this._years = value;
					this.SendPropertyChanged("years");
					this.OnyearsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aula", DbType="VarChar(20)")]
		public string aula
		{
			get
			{
				return this._aula;
			}
			set
			{
				if ((this._aula != value))
				{
					this.OnaulaChanging(value);
					this.SendPropertyChanging();
					this._aula = value;
					this.SendPropertyChanged("aula");
					this.OnaulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_horaInicio", DbType="VarChar(10)")]
		public string horaInicio
		{
			get
			{
				return this._horaInicio;
			}
			set
			{
				if ((this._horaInicio != value))
				{
					this.OnhoraInicioChanging(value);
					this.SendPropertyChanging();
					this._horaInicio = value;
					this.SendPropertyChanged("horaInicio");
					this.OnhoraInicioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_horaTerminno", DbType="VarChar(10)")]
		public string horaTerminno
		{
			get
			{
				return this._horaTerminno;
			}
			set
			{
				if ((this._horaTerminno != value))
				{
					this.OnhoraTerminnoChanging(value);
					this.SendPropertyChanging();
					this._horaTerminno = value;
					this.SendPropertyChanged("horaTerminno");
					this.OnhoraTerminnoChanged();
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
	
	public partial class SpMantCursosResult
	{
		
		private string _codCurso;
		
		private string _CurNomcurso;
		
		private string _codPrograma;
		
		private string _docCodigo;
		
		private string _years;
		
		private string _aula;
		
		private System.Nullable<System.TimeSpan> _horaInicio;
		
		private System.Nullable<System.TimeSpan> _horaTerminno;
		
		public SpMantCursosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codCurso", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string codCurso
		{
			get
			{
				return this._codCurso;
			}
			set
			{
				if ((this._codCurso != value))
				{
					this._codCurso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurNomcurso", DbType="VarChar(30)")]
		public string CurNomcurso
		{
			get
			{
				return this._CurNomcurso;
			}
			set
			{
				if ((this._CurNomcurso != value))
				{
					this._CurNomcurso = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codPrograma", DbType="Char(9)")]
		public string codPrograma
		{
			get
			{
				return this._codPrograma;
			}
			set
			{
				if ((this._codPrograma != value))
				{
					this._codPrograma = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_docCodigo", DbType="Char(9)")]
		public string docCodigo
		{
			get
			{
				return this._docCodigo;
			}
			set
			{
				if ((this._docCodigo != value))
				{
					this._docCodigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_years", DbType="Char(9)")]
		public string years
		{
			get
			{
				return this._years;
			}
			set
			{
				if ((this._years != value))
				{
					this._years = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aula", DbType="VarChar(20)")]
		public string aula
		{
			get
			{
				return this._aula;
			}
			set
			{
				if ((this._aula != value))
				{
					this._aula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_horaInicio", DbType="Time")]
		public System.Nullable<System.TimeSpan> horaInicio
		{
			get
			{
				return this._horaInicio;
			}
			set
			{
				if ((this._horaInicio != value))
				{
					this._horaInicio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_horaTerminno", DbType="Time")]
		public System.Nullable<System.TimeSpan> horaTerminno
		{
			get
			{
				return this._horaTerminno;
			}
			set
			{
				if ((this._horaTerminno != value))
				{
					this._horaTerminno = value;
				}
			}
		}
	}
	
	public partial class SPultimoCursoResult
	{
		
		private string _codCurso;
		
		public SPultimoCursoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codCurso", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string codCurso
		{
			get
			{
				return this._codCurso;
			}
			set
			{
				if ((this._codCurso != value))
				{
					this._codCurso = value;
				}
			}
		}
	}
}
#pragma warning restore 1591