﻿using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Player Inventory Body Item Data")]
    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventoryController)
        {
            var instantiated = 
                InstantiateAndInitializePrefab(targetPlayerInventoryController.Parent);
            
            //body probs
            Debug.Log("This Class is Player Inventory Body Item Data");
        }
    }
}
