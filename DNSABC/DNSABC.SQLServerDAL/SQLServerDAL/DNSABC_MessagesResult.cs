﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;//Please add references
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DNSABC_MessagesResult
	/// </summary>
	public partial class DNSABC_MessagesResult:IDNSABC_MessagesResult
	{
		public DNSABC_MessagesResult()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DNSABC_MessagesResult"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DNSABC_MessagesResult");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DNSABC.Model.DNSABC_MessagesResult model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DNSABC_MessagesResult(");
			strSql.Append("Id,MessagesID,UserID,AdminID,Title,Contents,IP,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@Id,@MessagesID,@UserID,@AdminID,@Title,@Contents,@IP,@CreateTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@MessagesID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Contents", SqlDbType.VarChar,8000),
					new SqlParameter("@IP", SqlDbType.VarChar,20),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.MessagesID;
			parameters[2].Value = model.UserID;
			parameters[3].Value = model.AdminID;
			parameters[4].Value = model.Title;
			parameters[5].Value = model.Contents;
			parameters[6].Value = model.IP;
			parameters[7].Value = model.CreateTime;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DNSABC.Model.DNSABC_MessagesResult model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DNSABC_MessagesResult set ");
			strSql.Append("MessagesID=@MessagesID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("AdminID=@AdminID,");
			strSql.Append("Title=@Title,");
			strSql.Append("Contents=@Contents,");
			strSql.Append("IP=@IP,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@MessagesID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@AdminID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.VarChar,200),
					new SqlParameter("@Contents", SqlDbType.VarChar,8000),
					new SqlParameter("@IP", SqlDbType.VarChar,20),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.MessagesID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.AdminID;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.Contents;
			parameters[5].Value = model.IP;
			parameters[6].Value = model.CreateTime;
			parameters[7].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DNSABC_MessagesResult ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DNSABC_MessagesResult ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DNSABC.Model.DNSABC_MessagesResult GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,MessagesID,UserID,AdminID,Title,Contents,IP,CreateTime from DNSABC_MessagesResult ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = Id;

			DNSABC.Model.DNSABC_MessagesResult model=new DNSABC.Model.DNSABC_MessagesResult();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MessagesID"]!=null && ds.Tables[0].Rows[0]["MessagesID"].ToString()!="")
				{
					model.MessagesID=int.Parse(ds.Tables[0].Rows[0]["MessagesID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AdminID"]!=null && ds.Tables[0].Rows[0]["AdminID"].ToString()!="")
				{
					model.AdminID=int.Parse(ds.Tables[0].Rows[0]["AdminID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Title"]!=null && ds.Tables[0].Rows[0]["Title"].ToString()!="")
				{
					model.Title=ds.Tables[0].Rows[0]["Title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Contents"]!=null && ds.Tables[0].Rows[0]["Contents"].ToString()!="")
				{
					model.Contents=ds.Tables[0].Rows[0]["Contents"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IP"]!=null && ds.Tables[0].Rows[0]["IP"].ToString()!="")
				{
					model.IP=ds.Tables[0].Rows[0]["IP"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,MessagesID,UserID,AdminID,Title,Contents,IP,CreateTime ");
			strSql.Append(" FROM DNSABC_MessagesResult ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,MessagesID,UserID,AdminID,Title,Contents,IP,CreateTime ");
			strSql.Append(" FROM DNSABC_MessagesResult ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DNSABC_MessagesResult ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from DNSABC_MessagesResult T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DNSABC_MessagesResult";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  Method
	}
}

