using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace StrayaSoft.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        void BottomStatusBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            GUILayout.Label("Status Bar");
            GUILayout.EndHorizontal();
        }
    }
}
