﻿using HotTaoCore.DAL;
using HotTaoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTaoCore.Logic
{
    public class LogicGoods
    {
        private static GoodsDAL dal = new GoodsDAL();

        private static LogicGoods _instance = new LogicGoods();

        public static LogicGoods Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// 商品列表
        /// </summary>
        /// <returns></returns>
        public List<GoodsModel> getGoodsList()
        {
            return dal.getGoodsList();
        }

        /// <summary>
        /// 分页数据
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<GoodsModel> getGoodsList(int pageIndex, int pageSize)
        {
            return dal.getGoodsList(pageIndex, pageSize);
        }

        /// <summary>
        /// 获取已选商品列表
        /// </summary>
        /// <param name="loginToken">The login token.</param>
        /// <returns>List&lt;GoodsModel&gt;.</returns>
        public List<GoodsModel> getGoodsList(string loginToken)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["token"] = loginToken;
            return BaseRequestService.Post<List<GoodsModel>>(ApiConst.getGoodsList, data);
        }


        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int addGoods(GoodsModel model)
        {
            return dal.addGoods(model);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteGoods(string loginToken,int id)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["token"] = loginToken;
            data["goodsid"] = id.ToString();
            return BaseRequestService.Post(ApiConst.delGoods, data);
        }        
    }
}
