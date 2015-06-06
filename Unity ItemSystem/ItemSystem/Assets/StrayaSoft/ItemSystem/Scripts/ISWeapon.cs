using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace StrayaSoft.ItemSystem
{
    [System.Serializable]
    public class ISWeapon : ISObject, IItemSystemWeapon, IItemSystemDestructable, IItemSystemEquipable,IItemSystemPrefab
    {
        [SerializeField] private int _minDamage;
        [SerializeField] private int _durability;
        [SerializeField] private int _maxDurability;
        [SerializeField] private ISEquipmentSlot _equipmentSlot;
        [SerializeField] private GameObject _prefab;

        public ISWeapon()
        {
            _equipmentSlot = new ISEquipmentSlot();
            
        }
        public ISWeapon(int durability, int maxDurability, ISEquipmentSlot equipmentSlot, GameObject prefab)
        {
            _durability = durability;
            _maxDurability = maxDurability;
            _equipmentSlot = equipmentSlot;
            _prefab = prefab;
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public int Durability
        {
            get { return _durability; }
        }

        public int MaxDurability
        {
            get { return _maxDurability; }
        }

        public ISEquipmentSlot EquipmentSlot
        {
            get { return _equipmentSlot; }
        } 



        public int Attack()
        {
            throw new NotImplementedException();
        }
        

        public void TakeDamage(int amount)
        {
            _durability -= amount;
            if (_durability < 0)
            {
                _durability = 0;
            }
            if (_durability == 0)
            {
                Break();
            }

        }

        public void Repair()
        {
            _maxDurability --;
            if(_maxDurability > 0)
                _durability = _maxDurability;

        }

        //reduce durability to 0
        public void Break()
        {
            _durability = 0;
        }

        

        public bool Equip()
        {
            throw new NotImplementedException();
        }

        public GameObject Prefab
        {
            get { return _prefab; }
           
        }

        public override void OnGUI()
        {
            base.OnGUI();
           
            _minDamage = int.Parse(EditorGUILayout.TextField("Min Damage:", _minDamage.ToString()));
            _durability = int.Parse(EditorGUILayout.TextField("Durability:", _durability.ToString()));
            _maxDurability = int.Parse(EditorGUILayout.TextField("Max Durability:", _maxDurability.ToString()));
            DisplayEquipmentSlot();
            DisplayPrefab();
            
        
        
        
        
        }

        public void DisplayEquipmentSlot()
        {
            GUILayout.Label("Equipment Slot");
            //[SerializeField] private ISEquipmentSlot _equipmentSlot;
        }

        public void DisplayPrefab()
        {
            GUILayout.Label("Prefab");
            //[SerializeField] private GameObject _prefab;
        }
    }
}
