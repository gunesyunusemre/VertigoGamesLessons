using UnityEngine;
using TopDownShooter.Scripts.Stats;

namespace TopDownShooter.Scripts.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Scriptable Shoot Manager")]
    public class ScriptableShootManager : AbstractScriptableManager<ScriptableShootManager>
    {
        public override void Initialize()
        {
            base.Initialize();
            Debug.Log("Scriptable ShootManager activated");
        }

        public override void Destroy()
        {
            base.Destroy();
            Debug.Log("Scriptable ShootManager destroyed");
        }

        public void Shoot(Vector3 origin, Vector3 direction)
        {
            RaycastHit rHit;
            var physic = Physics.Raycast(origin, direction, out rHit);
            if (physic)
            {
                Debug.Log("Collider: " +rHit.collider.name);
                int colliderInstanceID = rHit.collider.GetInstanceID();

                if (DamageableHelper.DamageableList.ContainsKey(colliderInstanceID))
                {
                    DamageableHelper.DamageableList[colliderInstanceID].Damage(5);
                }
            }
        }
    }
}
