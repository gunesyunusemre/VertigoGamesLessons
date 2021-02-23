using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Scripts.Stats
{
    public static class DamageableHelper
    {
        public static Dictionary<int, IDamageable> DamageableList = new Dictionary<int, IDamageable>();

        public static void InitializeDamageable(this IDamageable damageable)
        {
            DamageableList.Add(damageable.InstanceID, damageable);
        }
    }
    
    public interface IDamageable
    {
        int InstanceID { get; }
        void Damage(float dmg);
        
        
    }
}
