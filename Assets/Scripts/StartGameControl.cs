using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gframeworkDemo
{
    /// <summary>
    /// Control控制层：游戏入口
    /// </summary>
    public class StartGameControl : MonoBehaviour
    {
        private void Start()
        {
            //启动框架
            new ApplicationFacadeControl(this.gameObject);
        }

    }

}


