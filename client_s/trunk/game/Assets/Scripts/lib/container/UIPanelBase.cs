﻿using UnityEngine;
using System.Collections;

namespace XingLuoTianXia.lib 
{
    /// <summary>
    /// 面板基类
    /// </summary>
    public class UIPanelBase : MonoBehaviour
    {
        /// <summary>
        /// 面板名字
        /// </summary>
        public string panelName;

        /// <summary>
        /// 关闭
        /// </summary>
        /// <returns></returns>
        public bool close()
        {
            return UIManager.getInstance().closePanel(panelName);
        }
    }
}

