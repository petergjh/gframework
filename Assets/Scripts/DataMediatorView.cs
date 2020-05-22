using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace gframeworkDemo
{
    /// <summary>
    /// View视图层：显示玩家UI页面
    /// </summary>
    public class DataMediatorView : Mediator
    {
        //定义名称
        public new const string NAME = "DataMediatorView";
        //定义两个控件
        private Text TxtLevel;
        private Button BtnDisplayLevelNum;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="goRootNode">UI根节点</param>
        public DataMediatorView(GameObject goRootNode)
        {
            //视图类名称
            //MediatorViewName = mediatorViewName;
            //获取控件
            TxtLevel = goRootNode.transform.Find("Text_DisplayNum").gameObject.GetComponent<Text>();
            BtnDisplayLevelNum = goRootNode.transform.Find("Btn_Count").gameObject.GetComponent<Button>();
            //注册按钮点击事件
            BtnDisplayLevelNum.onClick.AddListener(OnClickAddingLevelNumber);
        }

        //用户点击事件
        private void OnClickAddingLevelNumber()
        {
            //定义消息，发消息到”控制层“
            SendNotification("Reg_StartDataCommand");
        }

        /// <summary>
        ///本视图层，允许接收的消息
        /// </summary>
        /// <returns></returns>
        public override IList<string> ListNotificationInterests()
        {
            IList<string> listResult = new List<string>();
            listResult.Add("Msg_AddLevel");
            return listResult;
        }
        //本视图层，允许接收的消息
        //public override string[] ListNotificationInterests()
        //{
        //    //return base.ListNotificationInterests();
        //    //声明一个空字符串数组用来存接收到的消息内容
        //    string[] listResult = new string[]{};
        //    //可以接收多条消息
        //    listResult[0]="Msg_AddLevel";
        //    return listResult;
        //}

        /// <summary>
        /// 处理消息
        /// </summary>
        /// <param name="notification"></param>
        public override void HandleNotification(INotification notification)
        {
            //base.HandleNotification(notification);
            switch (notification.Name)
            {
                case "Msg_AddLevel":
                    //把模型层发来的消息内容，显示给控件
                    MyDataModel myData = notification.Body as MyDataModel;
                    TxtLevel.text = myData.Level.ToString();
                    break;

                default:
                    break;
            }
        }


    }

}
