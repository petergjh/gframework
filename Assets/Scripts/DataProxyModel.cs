using PureMVC.Patterns.Proxy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace gframeworkDemo
{
    /// <summary>
    /// Model数据模型层: 数据模型代理类，数据的操作
    /// </summary>
    public class DataProxyModel : Proxy
    {
        //声明本类的名称
        public new const string NAME = "DataProxyModel";
        //引用“实体类”
        private MyDataModel _MyDataModel = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DataProxyModel() : base(NAME)
        {
            _MyDataModel = new MyDataModel();
        }

        /// <summary>
        /// 增加等级
        /// </summary>
        /// <param name="addNumber">增加的等级数量</param>
        public void AddLevel(int addNumber)
        {
            //把参数累加到“实体类”中
            _MyDataModel.Level += addNumber;
            //把数据变化发消息给“视图层”
            SendNotification("Msg_AddLevel", _MyDataModel);
        }

    }

}
