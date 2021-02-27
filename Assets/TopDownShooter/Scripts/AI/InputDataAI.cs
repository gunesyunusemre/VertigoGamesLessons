using TopDownShooter.Scripts.Input;
using UnityEngine;

namespace TopDownShooter.Scripts.AI
{
    public class InputDataAI : InputData
    {
        protected Vector3 _currentTarget;
        protected Transform _targetTransform;
        
        public void SetTarget(Transform targetTransform,Vector3 target)
        {
            _targetTransform = targetTransform;
            _currentTarget = target;
        }
        
        public override void ProcessInput()
        {
            base.ProcessInput();
        }
    }
}
