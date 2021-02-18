using System;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        private List<AbstractBasePlayerInventoryItemData> _instantiatedItemDataList;
        public Transform Parent;

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
            ClearInventory();

            _instantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(_inventoryItemDataArray.Length);
            for (int i = 0; i < inventoryDataArray.Length; i++)
            {
                var instantiated = Instantiate(_inventoryItemDataArray[i]);
                instantiated.CreateIntoInventory(this);
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
