
#if UNITY_EDITOR
using UnityEditor;

namespace Tyrant.Coloring
{
    public static class MenuItems
    {

        private const int Priority = 1000;

        [MenuItem("Assets/Coloring/Blue", false, Priority)]
        static void Blue()
        {
            
        }
        
        [MenuItem("Assets/Coloring/Red", false, Priority)]
        static void Red()
        {
            
        }

        [MenuItem("Assets/Coloring/Yellow", false, Priority)]
        static void Yellow()
        {
            
        }
        
        [MenuItem("Assets/Coloring/Custom Icon", false, Priority + 11)]
        static void CustomIcon()
        {
            
        }
        
        [MenuItem("Assets/Coloring/Reset Icon", false, Priority + 12)]
        static void ResetIcon()
        {
            
        }

        [MenuItem("Assets/Coloring/Blue", true)]
        [MenuItem("Assets/Coloring/Red", true)]
        [MenuItem("Assets/Coloring/Yellow", true)]
        [MenuItem("Assets/Coloring/Custom Icon", true)]
        [MenuItem("Assets/Coloring/Reset Icon", true)]
        static bool ValidateFolder()
        {
            if (Selection.activeObject == null) return false;

            var selected = Selection.activeObject;

            var path = AssetDatabase.GetAssetPath(selected);

            return AssetDatabase.IsValidFolder(path);
        }
        
    }
}
#endif