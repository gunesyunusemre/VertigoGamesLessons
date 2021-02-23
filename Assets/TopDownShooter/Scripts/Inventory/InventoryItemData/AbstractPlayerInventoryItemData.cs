using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    public enum InventoryItemDataType
    {
        Cannon,
        Body
    }

    public abstract class AbstractPlayerInventoryItemData<T> : AbstractBasePlayerInventoryItemData 
        where T :AbstractPlayerInventoryMono
    {
        [SerializeField] protected string _itemID;
        [SerializeField] protected InventoryItemDataType _inventoryItemData;
        [SerializeField] protected T _prefab;
        protected T _instantiated;
        
        protected T InstantiateAndInitializePrefab(Transform parent)
        {
            _instantiated=Instantiate(_prefab, parent);
            return _instantiated;
        }
        
    }
}
