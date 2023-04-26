/* 
****************************************************
* 文件：MessageData.cs
* 作者：小羊
* 创建时间：2023/04/25 00:38:35 星期二
* 功能：消息系统_保存发送的消息内容
****************************************************
*/
using UnityEngine.Events;

public interface IMessageData
{
}

public class MessageData<T> : IMessageData
{
    public UnityAction<T> MessageEvents;

    public MessageData(UnityAction<T> action)
    {
        MessageEvents += action;
    }
}