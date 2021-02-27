using System;
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


        private void OnDrawGizmos()
        {
            Gizmos.color=Color.blue;
            Gizmos.DrawSphere(_cannonShootPoint.position, 0.25f);
            Gizmos.color=Color.red;
            Gizmos.DrawLine(_cannonShootPoint.position, _cannonShootPoint.forward*10f);
        }
    }
}
