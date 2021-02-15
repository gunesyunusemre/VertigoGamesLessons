using UnityEngine;

namespace TopDownShooter.Scripts.PlayerControl
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float _horizontalSpeed=5;
        public float HorizontalSpeed => _horizontalSpeed;
        
        [SerializeField] private float _verticalSpeed=5;
        public float VerticalSpeed => _verticalSpeed;
    }
}
