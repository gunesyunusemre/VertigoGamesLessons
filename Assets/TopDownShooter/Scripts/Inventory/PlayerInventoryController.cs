using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace TopDownShooter.Scripts.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        private List<AbstractBasePlayerInventoryItemData> _instantiatedItemDataList;
        public Transform Parent;
        public ReactiveCommand ReactiveShootCommand { get; private set; }

        private void Start()
        {
            //For testing purposes only
            InitializeInventory(_inventoryItemDataArray);
        }

        private void OnDestroy()
        {
            ClearInventory();
        }

        private void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryDataArray)
        {
            //Adjecting reactive command
            ReactiveShootCommand?.Dispose();
            ReactiveShootCommand = new ReactiveCommand();
            
            //Clearing old Inventory and creating new one
            ClearInventory();
            _instantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(_inventoryItemDataArray.Length);
            for (int i = 0; i < inventoryDataArray.Length; i++)
            {
                var instantiated = Instantiate(_inventoryItemDataArray[i]);
               
                instantiated.Initialize(this);
                _instantiatedItemDataList.Add(instantiated);
            }
        }

        private void ClearInventory()
        {
            if (_instantiatedItemDataList!=null)
            {
                for (int i = 0; i < _instantiatedItemDataList.Count; i++)
                {
                    _instantiatedItemDataList[i].Destroy();
                }
            }
        }
    }
}
