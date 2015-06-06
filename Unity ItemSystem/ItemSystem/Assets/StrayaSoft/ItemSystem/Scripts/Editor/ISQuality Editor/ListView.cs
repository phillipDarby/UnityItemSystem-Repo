
using UnityEditor;
using UnityEngine;

namespace StrayaSoft.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor
    {
        
        //list all of the stored qualities in the database
        void ListView()
        {
            
            _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, GUILayout.ExpandHeight(true));
            DisplayQualities();
            EditorGUILayout.EndScrollView();


        }

        
        void DisplayQualities()
        {
            for (int cnt = 0; cnt < qualityDatabase.Count; cnt++)
            {
                GUILayout.BeginHorizontal("Box");
                //sprite

                if (qualityDatabase.Get(cnt).Icon)
                    Selectedtexture = qualityDatabase.Get(cnt).Icon.texture;
                else
                {
                    Selectedtexture = null;
                }
                   if(GUILayout.Button(Selectedtexture, GUILayout.Width(SPRITE_BUTTON_SIZE),
                    GUILayout.Height(SPRITE_BUTTON_SIZE)))
                   {
                       int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                       EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controllerID);
                       selectedIndex = cnt;
                   }
                   string commandName = Event.current.commandName;
                   if (commandName == "ObjectSelectorUpdated")
                   {
                       if (selectedIndex == -1)
                           return;
                       qualityDatabase.Get(selectedIndex).Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                       //selectedIndex = -1;
                       Repaint();
                   }
                
                
               
                GUILayout.BeginVertical();
                //name
                qualityDatabase.Get(cnt).Name = GUILayout.TextField(qualityDatabase.Get(cnt).Name);
                //delete button
                if (GUILayout.Button("X", GUILayout.Width(20)))
                {
                    if (EditorUtility.DisplayDialog("Delete Quality",
                        "Are you sure you want to delete " + qualityDatabase.Get(cnt).Name + " from the database?",
                        "Delete", "Cancel"))
                    {
                        qualityDatabase.Remove(cnt);
                    }
                }
                GUILayout.EndVertical();
                GUILayout.EndHorizontal();
            }
        }
    }
}
