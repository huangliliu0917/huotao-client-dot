﻿/*
 * 版权所有:杭州火图科技有限公司
 * 地址:浙江省杭州市滨江区西兴街道阡陌路智慧E谷B幢4楼在地图中查看
 * (c) Copyright Hangzhou Hot Technology Co., Ltd.
 * Floor 4,Block B,Wisdom E Valley,Qianmo Road,Binjiang District
 * 2013-2017. All rights reserved.
 * author guomw
**/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HOTReuestService
{

    /// <summary>
    /// java 接口请求类
    /// </summary>
    public class HotJavaApi
    {

        /// <summary>
        /// 根据商品优惠地址上传商品
        /// </summary>
        /// <param name="qq">当前采取者的QQ号</param>
        /// <param name="groupName">群标题（直播间）</param>
        /// <param name="urls">商品优惠券地址</param>
        /// <returns></returns>
        public bool UploadGoodsbyLink(string qq, string groupName, string urls)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["qq"] = qq;
            data["groupName"] = groupName;
            data["urls"] = urls;
            return HttpRequestService.Post(ApiDefineConst.uploadGoodsbyLink, data);
        }

        /// <summary>
        /// 获取【可绑定当前帐号到扫码微信号的二维码】
        /// </summary>
        /// <param name="loginToken"></param>
        /// <returns></returns>
        public string SubscribeForBind(string loginToken)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["token"] = loginToken;
            return HttpRequestService.PostToString(ApiDefineConst.subscribeForBind, data);
        }

        /// <summary>
        /// 推送通知到用户
        /// </summary>
        /// <param name="loginToken"></param>
        /// <param name="type">客户端离线(0),微信离线(1),群名(2)</param>
        /// <param name="extra"></param>
        /// <returns></returns>
        public string SendUserNotice(string loginToken, int type, string extra)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["token"] = loginToken;
            data["type"] = type.ToString();
            data["extra"] = extra;
            return HttpRequestService.PostToString(ApiDefineConst.sendUserNotice, data);
        }


    }
}
