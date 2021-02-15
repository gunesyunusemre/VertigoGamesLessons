using TopDownShooter.Scripts.Input;
using UnityEngine;

namespace TopDownShooter.Scripts.PlayerControl
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private InputData _inputData;
        [SerializeField] private Transform _target;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.forward * 
                                    (_inputData.Vertical * _playerMovementSettings.VerticalSpeed)));
            _target.Rotate(0,
                _inputData.Horizontal*_playerMovementSettings.HorizontalSpeed, 
                0,Space.Self);
        }
    }
}
