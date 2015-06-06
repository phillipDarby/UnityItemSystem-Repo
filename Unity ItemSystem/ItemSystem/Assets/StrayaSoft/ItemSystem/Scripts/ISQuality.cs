using UnityEngine;
using System.Collections;

namespace StrayaSoft.ItemSystem
{
    [System.Serializable]
    public class ISQuality : IItemSystemQuality
    {
        [SerializeField] private string _name;
        [SerializeField] private Sprite _icon;

        public ISQuality()
        {
            _icon = new Sprite();
            _name = "";
        }

        public ISQuality(string name, Sprite icon)
        {
            _name = name;
            _icon = icon;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Sprite Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }
    }
}