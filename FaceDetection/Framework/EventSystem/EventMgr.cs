using System;
using System.Collections.Generic;
using FaceDetection.Framework.DebugSystem;

namespace FaceDetection
{

    /// <summary>
    /// 事件管理器助手，扩展方法简化使用
    /// </summary>
    public static class EventMgrHelper
    {
        /// <summary>
        /// 调用事件触发拓展方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventName"></param>
        public static void TriggerEvent(this object sender, string eventName)
        {
            EventMgr.Instance.TriggerEvent(eventName, sender);
        }

        /// <summary>
        /// 调用事件触发拓展方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventName"></param>
        /// <param name="args"></param>
        public static void TriggerEvent(this object sender, string eventName, EventArgs args)
        {
            EventMgr.Instance.TriggerEvent(eventName, args);
        }
    }

    /// <summary>
    /// 事件管理器
    /// </summary>
    public class EventMgr
    {
        public static EventMgr Instance { get; private set; }

        public EventMgr()
        {
            if (Instance != null) return;

            Instance = this;

            Init();
        }

        public Dictionary<string, EventHandler> listeners;

        public void Init()
        {
            //create listeners dictionary when init
            listeners = new Dictionary<string, EventHandler>();
        }


        /// <summary>
        /// 添加监听器
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="eventHandler">处理函数</param>
        public void AddListener(string eventName, EventHandler eventHandler)
        {
            if (!listeners.ContainsKey(eventName))
            {
                listeners.Add(eventName, eventHandler);
            }
            else
            {
                listeners[eventName] += eventHandler;
            }
        }


        /// <summary>
        /// 移除监听器
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="eventHandler">处理函数</param>
        public void RemoveListener(string eventName, EventHandler eventHandler)
        {
            if (listeners.ContainsKey(eventName))
            {
                listeners[eventName] -= eventHandler;
            }
        }


        /// <summary>
        /// 清空监听器
        /// </summary>
        /// <param name="eventName">事件名称</param>
        public void ClearListener(string eventName)
        {
            if (listeners.ContainsKey(eventName))
            {
                listeners.Remove(eventName);
            }
        }


        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="sender">事件来源</param>
        public void TriggerEvent(string eventName, object sender)
        {
            if (listeners.ContainsKey(eventName))
            {
                listeners[eventName].Invoke(sender, EventArgs.Empty);
            }
            else
            {
                Debug.LogWarning("No listener for event: " + eventName);
            }
        }


        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="sender">事件来源</param>
        /// <param name="args">参数</param>
        public void TriggerEvent(string eventName, object sender, EventArgs args)
        {
            if (listeners.ContainsKey(eventName))
            {
                listeners[eventName].Invoke(sender, args);
            }
            else
            {
                Debug.LogWarning("No listener for event: " + eventName);
            }
        }
    }

}
