/* 
****************************************************
* 文件：MonoSingleton.cs
* 作者：小羊
* 创建时间：2023/04/25 00:24:34 星期二
* 功能：Mono单例
****************************************************
*/
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance = null;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject(typeof(T).Name, new[] {typeof(T)});
                    DontDestroyOnLoad(obj);
                    _instance = obj.GetComponent<T>();
                    (_instance as IInitable)?.Init();
                }
                else
                {
                    Debug.LogWarning("Instance is already exist!");
                }
            }

            return _instance;
        }
    }

    /// <summary>
    /// 继承Mono单例的类如果写了Awake方法，需要在Awake方法最开始的地方调用一次base.Awake()，来给_instance赋值
    /// </summary>
    private void Awake()
    {
        _instance = this as T;
        DontDestroyOnLoad(this);
    }
}