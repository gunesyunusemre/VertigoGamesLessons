using UnityEngine;

namespace TopDownShooter.Scripts.Camera
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed => _rotationLerpSpeed;

        [Header("Position")]
        [SerializeField] private Vector3 _positionOffset;

        public Vector3 PositionOffset => _positionOffset;
        
        [SerializeField] private float _positionLerpSpeed = 1;

        public float PositionLerpSpeed => _positionLerpSpeed;
    }
}

