using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Player Inventory Body Item Data")]
    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyMono>
    {
        public override void Initialize(PlayerInventoryController targetPlayerInventoryController)
        {
            var instantiated = 
                InstantiateAndInitializePrefab(targetPlayerInventoryController.BodyParent);
            
            //body probs
            Debug.Log("This Class is Player Inventory Body Item Data");
        }
    }
}
