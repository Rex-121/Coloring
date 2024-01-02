using UnityEditor;
using UnityEngine;

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
    }
}
