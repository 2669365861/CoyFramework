/* 
****************************************************
* 文件：MessageManager.cs
* 作者：小羊
* 创建时间：2023/04/25 00:31:29 星期二
* 功能：简版的自定义消息系统
****************************************************
*/
using System.Collections.Generic;
using UnityEngine.Events;

public class MessageManager : Singleton<MessageManager>
{
    private Dictionary<string, IMessageData> dictionaryMessage;

    public MessageManager()
    {
        InitData();
    }

    private void InitData()
    {
        dictionaryMessage = new Dictionary<string, IMessageData>();
    }

    //注册
    public void Register<T>(string key, UnityAction<T> action)
    {
        if (dictionaryMessage.TryGetValue(key, out var previousAction))
        {
            if (previousAction is MessageData<T> messageData)
            {
                messageData.MessageEvents += action;
            }
        }
        else
        {
            dictionaryMessage.Add(key, new MessageData<T>(action));
        }
    }

    //移除
    public void Remove<T>(string key, UnityAction<T> action)
    {
        if (dictionaryMessage.TryGetValue(key, out var previousAction))
        {
            if (previousAction is MessageData<T> messageData)
            {
                messageData.MessageEvents -= action;
            }
        }
    }
    
    //触发消息
    public void Send<T>(string key, T data)
    {
        if (dictionaryMessage.TryGetValue(key, out var previousAction))
        {
            (previousAction as MessageData<T>)?.MessageEvents.Invoke(data);
        }
    }

    //清空
    public void Clear()
    {
        dictionaryMessage.Clear();
    }
}