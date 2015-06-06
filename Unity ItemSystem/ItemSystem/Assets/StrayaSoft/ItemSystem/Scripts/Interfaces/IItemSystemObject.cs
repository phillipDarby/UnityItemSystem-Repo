using UnityEngine;
using System.Collections;

namespace StrayaSoft.ItemSystem
{
    public interface IItemSystemObject
    {
        //name
        string ISName { get; set; }
        //value
        int ISValue { get; set; }
        //icon
        Sprite ISIcon { get; set; }
        //burden
        int ISBurden { get; set; }
        //quality level
        ISQuality IsQuality { get; set; }

        /* These go to other item interfaces
         * 
         * equip
         * questItem Flag
         * prefab
         * 
         */ 
    }
}