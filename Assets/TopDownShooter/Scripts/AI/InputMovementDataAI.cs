using UnityEngine;

namespace TopDownShooter.Scripts.AI
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Input/AI/AI Movement Input")]
    public class InputMovementDataAI : InputDataAI
    {
        public override void ProcessInput()
        {
            float distance = Vector3.Distance(_targetTransform.position,
                _currentTarget);
            if (distance>0)
            {
                Vertical = 1;
            }
            else
            {
                Vertical = 0;
            }
            
            Vector3 dir = _currentTarget - _targetTransform.position;
            var rotation = Quaternion.LookRotation(dir, Vector3.up).eulerAngles;
            var rotationGap = Mathf.Abs(rotation.y - _targetTransform.eulerAngles.y);
            if (Mathf.Abs(rotationGap)> 5f)
            {
                float horizontalClamp = Mathf.Clamp(rotationGap / 180f, -1, 1);
                Horizontal = horizontalClamp;
            }
            else
            {
                Horizontal = 0;
            }
        }
    }
}
