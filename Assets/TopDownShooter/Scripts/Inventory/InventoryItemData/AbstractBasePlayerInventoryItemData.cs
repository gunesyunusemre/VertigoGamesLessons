using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        public abstract void CreateIntoInventory(PlayerInventoryController targetPlayerInventoryController);

        public virtual void Destroy()
        {
            Destroy(this);
        }

    }
}
