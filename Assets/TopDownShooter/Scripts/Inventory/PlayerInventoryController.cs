using System;
using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        public Transform Parent;

        private void Start()
        {
            //For testing purposes only
            InitializeInventory(_inventoryItemDataArray);
        }

        private void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryDataArray)
        {
            for (int i = 0; i < inventoryDataArray.Length; i++)
            {
                inventoryDataArray[i].CreateIntoInventory(this);
            }
        }
    }
}
