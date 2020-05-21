using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gframeworkDemo
{
    /// <summary>
    /// Model数据模型层：数据实体类，存储原始数据
    /// </summary>
    public class MyDataModel 
    {
        private int _Level = 0;

        /// <summary>
        /// 玩家等级
        /// </summary>
        public int Level { get => _Level; set => _Level = value; }
    }
}
