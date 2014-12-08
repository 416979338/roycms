using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using ROYcms.Sys.DAL;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_Admin 的摘要说明。
	/// </summary>
	public class ROYcms_Admin
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Admin dal=new ROYcms.Sys.DAL.ROYcms_Admin();
		public ROYcms_Admin()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
        /// <summary>
        /// 验证用户
        /// </summary>
        public bool Exists(string username, string password)
        {
            return dal.Exists(username, password);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Admin model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_Admin model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			dal.Delete(id);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Admin GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Admin GetModel(string name)
        {

            return dal.GetModel(name);
        }
		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Admin GetModelByCache(int id)
		{
			
			string CacheKey = PubConstant.date_prefix + "AdminModel-" + id;
            object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
                        int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
                        ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Sys.Model.ROYcms_Admin)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Admin> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Admin> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Admin> modelList = new List<ROYcms.Sys.Model.ROYcms_Admin>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Admin model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Admin();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					model.name=dt.Rows[n]["name"].ToString();
					model.password=dt.Rows[n]["password"].ToString();
					model.classkind=dt.Rows[n]["classkind"].ToString();
					if(dt.Rows[n]["Rol"].ToString()!="")
					{
						model.Rol=int.Parse(dt.Rows[n]["Rol"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  成员方法
	}
}

