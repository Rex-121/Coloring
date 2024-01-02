
using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

#if UNITY_EDITOR

namespace Tyrant.Coloring
{
    
    [InitializeOnLoad]
    public static class ColoredFolder
    {
        static ColoredFolder()
        {
            EditorApplication.projectWindowItemOnGUI -= OnGUI;
            EditorApplication.projectWindowItemOnGUI += OnGUI;
        }

        private static void OnGUI(string guid, Rect selectionRect)
        {

            Rect rect;

            var color = new Color(0.15f, 0.15f, 0.15f);
            
            switch (selectionRect.x)
            {
                case < 15:
                    // 小图标
                    rect = new Rect(selectionRect.x, selectionRect.y, selectionRect.height + 0.5f, selectionRect.height);
                    break;
                case >= 15 when selectionRect.height < 30:
                    // 中图标
                    rect = new Rect(selectionRect.x, selectionRect.y, selectionRect.height, selectionRect.height);
                     color = new Color(0.22f, 0.22f, 0.22f);
                    break;
                default:
                    // 大图标
                    color = Color.clear;
                    var height = 40;
                    rect = new Rect(
                        selectionRect.x + selectionRect.width - height,
                        selectionRect.y + selectionRect.height - height * 2, 
                        40, 40);
                    break;
            }

            {

                var path = AssetDatabase.GUIDToAssetPath(guid);
                if (path.EndsWith("Assets/Scripts"))
                {
                    EditorGUI.DrawRect(rect, color);
                    var tex = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Plugins/Coloring/Icons/Scripts.png");
                    GUI.DrawTexture(rect, tex);
                }

                if (path.EndsWith("Assets/SO"))
                {
                    EditorGUI.DrawRect(rect, color);
                    var tex = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Plugins/Coloring/Icons/SO.png");
                    GUI.DrawTexture(rect, tex);
                }
            }
            
            

            var selectedGuid = Selection.activeObject.Guid().ToString();

            if (guid != selectedGuid) return;
            
                // EditorGUI.DrawRect(rect, color);
                // var tex = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Plugins/Coloring/Icons/Squads.png");
                // GUI.DrawTexture(rect, tex);
            
            
            // EditorGUI.DrawRect(selectionRect, Color.blue);
        }

        public static void SetIconName(string iconName)
        {
            
        }
    }


    public static class SelectionExt
    {

        public static string AssetPath(this Object o) => AssetDatabase.GetAssetPath(o);
        
        public static GUID Guid(this Object o) => AssetDatabase.GUIDFromAssetPath(o.AssetPath());
        
        
    }
    
    
}

#endif