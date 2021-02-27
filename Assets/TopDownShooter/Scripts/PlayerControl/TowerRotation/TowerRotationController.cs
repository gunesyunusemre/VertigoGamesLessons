using System;
using TopDownShooter.Scripts.Input;
using UnityEngine;

namespace TopDownShooter.Scripts.PlayerControl
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _rotationInput;
        [SerializeField] private Transform _towerTransform;
        public Transform TowerTransform => _towerTransform;
        [SerializeField] private TowerRotationSetting _towerRotationSetting;

        public void InitializeInput(InputData InputData)
        {
            _rotationInput = InputData;
        }
        
        private void Update()
        {
            _towerTransform.Rotate(0,
                _rotationInput.Horizontal*_towerRotationSetting.TowerRotationSpeed,
                0,Space.Self);
        }
    }
}
