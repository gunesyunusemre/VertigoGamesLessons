using System;
using UnityEngine;

namespace FirstLessonsBasic.Lessons
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidbodySettings _settings;

        private void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceKeyDown)
            {
                _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}
