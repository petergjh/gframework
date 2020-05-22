using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gframeworkDemo
{
    /// <summary>
    /// Control控制层：整体项目控制类
    /// </summary>
    public class ApplicationFacadeControl : Facade
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="goRootNode">UI根节点</param>
        public ApplicationFacadeControl(GameObject goRootNode)
        {
            //MVC三层的关联绑定
            //控制层注册 (视图层"命令消息"与控制层类的对应绑定)
            RegisterCommand("Reg_StartDataCommand", typeof(DataCommandControl));
            //视图层注册
            RegisterMediator(new DataMediatorView(goRootNode));
            //模型层注册
            RegisterProxy(new DataProxyModel());
        }

    }
}


