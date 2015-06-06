using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace StrayaSoft.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        private ISWeaponDatabase database;

       
        
        private const string DATABASE_NAME = @"StrayaSoftWeaponDatabase.asset";
        private const string DATABASE_PATH = @"DataBase";
        private const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;

        [MenuItem("StrayaSoft/Database/Item System Editor %#w")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.title = "Item System";
            window.Show();
        }

        void OnEnable()
        {
            if (database == null)
                database = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(DATABASE_PATH, DATABASE_NAME);
        }

        void OnGUI()
        {
            TopTabBar();
            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();
            BottomStatusBar();
        }
    }
}
