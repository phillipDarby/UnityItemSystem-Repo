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
        private Vector2 _scrollPos = Vector2.zero;
        private int ListViewWidth = 200;
        void ListView()
        {
            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(ListViewWidth));
            GUILayout.Label("List View");


            GUILayout.EndScrollView();
        }
    }
}
