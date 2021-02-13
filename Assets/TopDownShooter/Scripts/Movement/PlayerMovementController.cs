using System;
using TopDownShooter.Scripts.Input;
using UnityEngine;

namespace TopDownShooter.Scripts.Movement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private InputData _inputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.forward * 
                                    (_inputData.Vertical * _playerMovementSettings.VerticalSettings)));
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.right * 
                                    (_inputData.Horizontal * _playerMovementSettings.HorizontalSettings)));
        }
    }
}
