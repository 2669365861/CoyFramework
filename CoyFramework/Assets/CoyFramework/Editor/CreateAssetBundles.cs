using UnityEngine;
using UnityEditor;
using System.IO;

/// <summary>
/// AB包创建
/// </summary>
public class CreateAssetBundles : MonoBehaviour
{
    [MenuItem("CoyFramework/AssetBundles/Build AssetBundles(WebGL)")] //特性
    static void BuildAssetBundle_WebGL()
    {
        string dir = Application.streamingAssetsPath + "/AssetBundles"; //相对路径
        if (!Directory.Exists(dir))   //判断路径是否存在
        {
            Directory.CreateDirectory(dir);
        }
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.WebGL); //这里是第一点注意事项，BuildTarget类型选择WebGL
    }
    [MenuItem("CoyFramework/AssetBundles/Build AssetBundles(StandaloneWindows64)")] //特性
    static void BuildAssetBundle_StandaloneWindows64()
    {
        string dir = Application.streamingAssetsPath + "/AssetBundles"; //相对路径
        if (!Directory.Exists(dir))   //判断路径是否存在
        {
            Directory.CreateDirectory(dir);
        }
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64); //这里是第一点注意事项，BuildTarget类型选择WebGL
    }
    [MenuItem("CoyFramework/AssetBundles/Build AssetBundles(Android)")] //特性
    static void BuildAssetBundle_Android()
    {
        string dir = Application.streamingAssetsPath + "/AssetBundles"; //相对路径
        if (!Directory.Exists(dir))   //判断路径是否存在
        {
            Directory.CreateDirectory(dir);
        }
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.Android); //这里是第一点注意事项，BuildTarget类型选择WebGL
    }
    [MenuItem("CoyFramework/AssetBundles/Build AssetBundles(iOS)")] //特性
    static void BuildAssetBundle_iOS()
    {
        string dir = Application.streamingAssetsPath + "/AssetBundles"; //相对路径
        if (!Directory.Exists(dir))   //判断路径是否存在
        {
            Directory.CreateDirectory(dir);
        }
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.iOS); //这里是第一点注意事项，BuildTarget类型选择WebGL
    }
}