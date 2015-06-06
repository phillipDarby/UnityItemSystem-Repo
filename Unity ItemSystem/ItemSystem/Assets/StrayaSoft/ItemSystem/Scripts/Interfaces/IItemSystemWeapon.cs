using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrayaSoft.ItemSystem
{
    public interface IItemSystemWeapon
    {
        int MinDamage { get; set; }
        int Attack();

    }
}
