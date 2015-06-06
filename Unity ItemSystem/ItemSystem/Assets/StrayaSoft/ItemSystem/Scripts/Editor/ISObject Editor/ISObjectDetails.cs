using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace StrayaSoft.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        private ISWeapon tempWeapon = new ISWeapon();
        private bool showNewWeaponDetails = false;

        void ItemDetails()
        {
            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            if (showNewWeaponDetails)
            {
                DisplayNewWeapon();
            }

            GUILayout.EndVertical();
            GUILayout.Space(50);

            GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
            DisplayButtons();
            GUILayout.EndHorizontal();
           
            GUILayout.EndVertical();
           
        }

        void DisplayNewWeapon()
        {
          
            tempWeapon.OnGUI();
            
            
            
        }

        void DisplayButtons()
        {
            if (!showNewWeaponDetails)
            {
                if (GUILayout.Button("Create Weapon"))
                {
                    tempWeapon = new ISWeapon();
                    showNewWeaponDetails = true;
                }
            }
            else
            {
                if (GUILayout.Button("Save"))
                {

                    showNewWeaponDetails = false;
                    tempWeapon = null;
                }
                if (GUILayout.Button("Cancel"))
                {

                    showNewWeaponDetails = false;
                    tempWeapon = null;
                }
            }
           
        }
    }
}
