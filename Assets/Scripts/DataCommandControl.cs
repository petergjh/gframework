using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gframeworkDemo
{
    /// <summary>
    /// Control控制层：数据控制类，接收玩家的输入，或视图层传来的消息
    /// </summary>
    public class DataCommandControl : SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            //base.Execute(notification);
            //调用数据模型层的“增加等级”方法
            DataProxyModel datapro = (DataProxyModel)Facade.RetrieveProxy(DataProxyModel.NAME);
            datapro.AddLevel(10);
        }

    }

}


