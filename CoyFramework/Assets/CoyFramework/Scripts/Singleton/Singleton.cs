/* 
****************************************************
* 文件：Singleton.cs
* 作者：小羊
* 创建时间：2023/04/25 00:18:02 星期二
* 功能：单例系统(只存在于内存的单例)
****************************************************
*/

public class Singleton<T> where T : new()
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
                (_instance as IInitable)?.Init();
            }

            return _instance;
        }
    }
}
