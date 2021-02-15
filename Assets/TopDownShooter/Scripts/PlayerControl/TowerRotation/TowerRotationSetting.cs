using UnityEngine;

namespace TopDownShooter.Scripts.PlayerControl
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Player/Tower Rotation Settings")]
    public class TowerRotationSetting : ScriptableObject
    {
        public float TowerRotationSpeed = 1f;
    }
}
