using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrayaSoft.ItemSystem
{
    public interface IItemSystemStackable
    {
        int MaxStack { get; }
        int Stack(int amount); //default value 0
        
    }
}
