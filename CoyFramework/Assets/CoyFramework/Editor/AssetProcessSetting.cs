/* 
****************************************************
* 文件：AssetProcessSetting.cs
* 作者：小羊
* 创建时间：2023/04/24 23:55:58 星期一
* 功能：资源导入自动设置
****************************************************
*/
using UnityEditor;
using UnityEngine;

public class AssetProcessSetting : AssetPostprocessor
{
    private void OnPreprocessTexture()
    {
        TextureImporter textureImporter = (TextureImporter)assetImporter;
        if (assetPath.Contains("Assets/Resources/sprites"))
        {
            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.textureShape = TextureImporterShape.Texture2D;
            textureImporter.mipmapEnabled = false;
            textureImporter.isReadable = false;
        }
    }
}
