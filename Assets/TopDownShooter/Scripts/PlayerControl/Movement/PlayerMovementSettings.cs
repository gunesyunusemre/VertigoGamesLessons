using UnityEngine;

namespace TopDownShooter.Scripts.PlayerControl
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float _horizontalSettings=5;
        public float HorizontalSettings => _horizontalSettings;
        
        [SerializeField] private float _verticalSettings=5;
        public float VerticalSettings => _verticalSettings;

        [SerializeField] private float _jumpSettings = 1;
        public float JumpSettings => _jumpSettings;
    }
}
