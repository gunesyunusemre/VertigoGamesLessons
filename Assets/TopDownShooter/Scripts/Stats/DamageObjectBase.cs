using System;
using UniRx;
using UnityEngine;

namespace TopDownShooter.Scripts.Stats
{
    
    public class DamageObjectBase : MonoBehaviour, IDamageable
    {
        [SerializeField] private Collider _collider;
        public int InstanceID { get; private set; }
        public float Health = 100f;
        private Vector3 _deaultScale;
        private float _defaultHealth;
        public ReactiveCommand onDeath = new ReactiveCommand();
        
        protected  virtual void Awake()
        {
            InstanceID = _collider.GetInstanceID();
            this.InitializeDamageable();
            _deaultScale = transform.localScale;
            _defaultHealth = Health / 3f;
        }

        protected virtual void Destroy()
        {
            this.DestroyDamageable();
        }
        
        public virtual void Damage(float dmg)
        {
            Health -= dmg;
            Debug.Log("You damaged me: "+dmg+" Current Health: "+ Health);
            if (Health<=0)
            {
                onDeath.Execute();
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            /*transform.localScale = Vector3.Lerp(transform.localScale,(Health/100f)*_deaultScale,
                Time.deltaTime*2f);*/
        }
    }
}
