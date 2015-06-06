using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrayaSoft.ItemSystem
{
    public interface IItemSystemEquipmentSlot
    {
        string Name { get; set; }
        Sprite Icon { get; set; }
    }
}
