using System;
using UnityEngine;

namespace TopDownShooter.Scripts.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _rotationTargetTransform;
        [SerializeField] private Transform _positionTargetTransform;
        [SerializeField] private Transform _cameraTransform;

        private void Update()
        {
            CameraMovementFollow();
            CameraRotationFollow();
        }

        private void CameraRotationFollow()
        {
            _cameraTransform.rotation=Quaternion.Lerp(_cameraTransform.rotation,
                Quaternion.LookRotation(_rotationTargetTransform.forward),
                Time.deltaTime*_cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            /*_cameraTransform.localPosition = Vector3.Lerp(_cameraTransform.localPosition,
                _cameraTransform.InverseTransformPoint(_positionTargetTransform.position) + 
                _cameraSettings.PositionOffset,
                Time.deltaTime*_cameraSettings.PositionLerpSpeed);*/

            _cameraTransform.localPosition = _cameraSettings.PositionOffset;
        }
    }
}

