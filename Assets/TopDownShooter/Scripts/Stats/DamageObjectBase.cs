using System;
using UnityEngine;

namespace TopDownShooter.Scripts.Stats
{
    
    public class DamageObjectBase : MonoBehaviour, IDamageable
    {
        [SerializeField] private Collider _collider;
        public int InstanceID { get; private set; }
        
        protected  virtual void Awake()
        {
            InstanceID = _collider.GetInstanceID();
            this.InitializeDamageable();
        }
        
        public virtual void Damage(float dmg)
        {
            Debug.Log("You damaged me: "+dmg);
        }

        
    }
}
