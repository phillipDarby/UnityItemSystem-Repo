using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrayaSoft.ItemSystem
{
    public interface IItemSystemEquipable
    {
        ISEquipmentSlot EquipmentSlot { get; }
        bool Equip();
    }
}
