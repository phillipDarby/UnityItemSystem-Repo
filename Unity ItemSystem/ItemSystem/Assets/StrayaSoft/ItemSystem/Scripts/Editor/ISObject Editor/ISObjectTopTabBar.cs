using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace StrayaSoft.ItemSystem.Editor
{
    public partial class ISObjectEditor 
    {
        void TopTabBar()
        {
            GUILayout.BeginHorizontal("Box",GUILayout.ExpandWidth(true));
            WeaponTab();
            ArmorTab();
            GUILayout.Button("Potions");
            AboutTab();
            GUILayout.EndHorizontal();
        }

        void WeaponTab()
        {
            GUILayout.Button("Weapons");
        }

        void ArmorTab()
        {
            GUILayout.Button("Armor");
        }

        void AboutTab()
        {
            GUILayout.Button("About");
        }
    }
}
