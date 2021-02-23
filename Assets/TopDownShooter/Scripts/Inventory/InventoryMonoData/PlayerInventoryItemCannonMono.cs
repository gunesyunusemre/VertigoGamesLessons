using UnityEngine;

namespace TopDownShooter.Scripts.Inventory
{
    public class PlayerInventoryItemCannonMono : AbstractPlayerInventoryMono
    {
        [SerializeField] private Transform _cannonShootPoint;
        
        public void Shoot()
        {
            
            //add also effects and such
            ScriptableShootManager.Instance.Shoot(_cannonShootPoint.position, 
                _cannonShootPoint.forward);
        }
    }
}
