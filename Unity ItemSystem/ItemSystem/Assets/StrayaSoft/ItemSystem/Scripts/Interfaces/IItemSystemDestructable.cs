using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrayaSoft.ItemSystem
{
    public interface IItemSystemDestructable
    {
        int Durability { get; }
        int MaxDurability { get; }
        void TakeDamage(int amount);
        void Repair();
        void Break();
    }
}
