using UnityEngine;

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
    }
}
