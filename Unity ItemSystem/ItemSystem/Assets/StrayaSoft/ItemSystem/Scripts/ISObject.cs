
using UnityEngine;
using System.Collections;
using UnityEditor;

namespace StrayaSoft.ItemSystem
{
    [System.Serializable]
    public class ISObject : IItemSystemObject
    {
        [SerializeField] private string _name;
        [SerializeField] private int _value;
        [SerializeField] private Sprite _icon;
        [SerializeField] private int _burden;
        [SerializeField] private ISQuality _quality;

        public string ISName
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ISValue
        {
            get { return _value; }
            set { _value = value; }
        }

        public Sprite ISIcon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public int ISBurden
        {
            get { return _burden; }
            set { _burden = value; }
        }

        public ISQuality IsQuality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        //this code to be placed in a new class later on
        public virtual void OnGUI()
        {
            GUILayout.BeginVertical();
            _name = EditorGUILayout.TextField("Name:", _name);
            _value = int.Parse(EditorGUILayout.TextField("Value:", _value.ToString()));
            _burden = int.Parse(EditorGUILayout.TextField("Burden:", _burden.ToString()));
            DisplayIcon();
            DisplayQuality();
            GUILayout.EndVertical();
        }

        public void DisplayIcon()
        {
            GUILayout.Label("Icon");
        }

        public void DisplayQuality()
        {
            GUILayout.Label("Quality");
        }
    }
}