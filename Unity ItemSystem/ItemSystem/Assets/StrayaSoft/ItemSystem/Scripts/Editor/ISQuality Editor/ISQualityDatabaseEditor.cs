using UnityEditor;
using UnityEngine;
using System.Collections;

namespace StrayaSoft.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {
        private ISQualityDatabase qualityDatabase;
        
        private int selectedIndex = -1;
        private Texture2D Selectedtexture;
        private Vector2 _scrollPos; // scroll position for the list view


        private const int SPRITE_BUTTON_SIZE = 46;
        private const string DATABASE_PATH = @"DataBase";
        private const string DATABASE_NAME = @"StrayaSoftQualityDatabase.asset";
        private const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;


        [MenuItem("StrayaSoft/Database/Quality Editor %#i")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400,300);
            window.title = "Quality Database";
            window.Show();
        }

        void OnEnable()
        {
            if(qualityDatabase == null)
            qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
        }

        void OnGUI()
        {
            if (qualityDatabase == null)
            {
                Debug.LogWarning("Quality Database not loaded");
            }
           ListView();
           
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
        }

        void BottomBar()
        {
            //count
            GUILayout.Label("Qualities: " + qualityDatabase.Count);
            //add button
            if (GUILayout.Button("Add"))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }

      
    }
}