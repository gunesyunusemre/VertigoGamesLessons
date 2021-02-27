using UnityEngine;

namespace TopDownShooter.Scripts.AI
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Input/AI/AI Rotation Input")]
    public class InputRotationDataAI : InputDataAI
    {
        public override void ProcessInput()
        {
            Vector3 dir = _currentTarget - _targetTransform.position;
            var rotation = Quaternion.LookRotation(dir, Vector3.up).eulerAngles;
            var rotationGap = Mathf.Abs(rotation.y - _targetTransform.eulerAngles.y);
            if (Mathf.Abs(rotationGap)> 5f)
            {
                var horizontalClamp = Mathf.Clamp(rotationGap / 180, -1, 1);

                Horizontal = horizontalClamp;
            }
            else
            {
                Horizontal = 0;
            }
        }
    }
}
