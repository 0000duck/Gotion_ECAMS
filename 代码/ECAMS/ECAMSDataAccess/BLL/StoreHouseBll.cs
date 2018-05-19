﻿/**  版本信息模板在安装目录下，可自行修改。
* StoreHouse.cs
*
* 功 能： N/A
* 类 名： StoreHouse
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-12-1 12:50:06   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：np　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;

using ECAMSDataAccess;
namespace ECAMSDataAccess
{
	/// <summary>
	/// 物料信息表
	/// </summary>
	public partial class StoreHouseBll
	{
		private readonly ECAMSDataAccess.StoreHouseDal dal=new ECAMSDataAccess.StoreHouseDal();
		public StoreHouseBll()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public long GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int StoreHouseID)
		{
			return dal.Exists(StoreHouseID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ECAMSDataAccess.StoreHouseModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ECAMSDataAccess.StoreHouseModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int StoreHouseID)
		{
			
			return dal.Delete(StoreHouseID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string StoreHouseIDlist )
		{
			return dal.DeleteList(StoreHouseIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ECAMSDataAccess.StoreHouseModel GetModel(int StoreHouseID)
		{
			
			return dal.GetModel(StoreHouseID);
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
		public List<ECAMSDataAccess.StoreHouseModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ECAMSDataAccess.StoreHouseModel> DataTableToList(DataTable dt)
		{
			List<ECAMSDataAccess.StoreHouseModel> modelList = new List<ECAMSDataAccess.StoreHouseModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECAMSDataAccess.StoreHouseModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
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

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

