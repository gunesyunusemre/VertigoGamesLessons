using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Player Inventory Cannon Item Data")]
    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryItemCannonMono>
    {
        [SerializeField] private float _damage;
        public float Damage => _damage;

        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventoryController)
        {
            var instantiated = 
                InstantiateAndInitializePrefab(targetPlayerInventoryController.Parent);
            
            //Cannon probs
            Debug.Log("This Class is Player Inventory Cannon Item Data");
        }
    }
}
