using UnityEngine;
using UniRx;

namespace TopDownShooter.Scripts.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        private PlayerInventoryController _inventoryController;
        protected CompositeDisposable _compositeDisposable;

        public virtual void Initialize(PlayerInventoryController targetPlayerInventoryController)
        {
            _inventoryController = targetPlayerInventoryController;
            _compositeDisposable = new CompositeDisposable();
        }

        public virtual void Destroy()
        {
            //Means unsubscribing from all events we add to this
            _compositeDisposable.Dispose();
            Destroy(this);
        }

    }
}
