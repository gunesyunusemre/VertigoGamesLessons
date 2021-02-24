using UnityEngine;
using UniRx;

namespace TopDownShooter.Scripts.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Player Inventory Cannon Item Data")]
    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryItemCannonMono>
    {
        [SerializeField] private float _damage;
        [SerializeField] private float _rpm=1f;
        private float _lastShootTime;
        public float Damage => _damage;
        public float Rpm => _rpm;

        public override void Initialize(PlayerInventoryController targetPlayerInventoryController)
        {
            base.Initialize(targetPlayerInventoryController);
            
            InstantiateAndInitializePrefab(targetPlayerInventoryController.CannonParent);
            targetPlayerInventoryController.ReactiveShootCommand
                .Subscribe(OnReactiveShootCommand)
                .AddTo(_compositeDisposable);
            
            //Cannon probs
            Debug.Log("This Class is Player Inventory Cannon Item Data");
        }

        public override void Destroy()
        {
            base.Destroy();
        }

        private void OnReactiveShootCommand(Unit obj)
        {
            Debug.Log("Reactive Shoot Command");
            Shoot();
        }

        private void Shoot()
        {
            if (Time.time - _lastShootTime >= _rpm)
            {
                _instantiated.Shoot();
                _lastShootTime = Time.time;
            }
            else
            {
                Debug.LogError("You can't shoot now!");
            }
            
        }
    }
}
