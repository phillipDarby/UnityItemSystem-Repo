using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrayaSoft.ItemSystem
{
    public class ISEquipmentSlot : IItemSystemEquipmentSlot
    {
        [SerializeField] private string _name;
        [SerializeField] private Sprite _icon;

        public ISEquipmentSlot()
        {
            _name = "Name Me";
            _icon = new Sprite();
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
