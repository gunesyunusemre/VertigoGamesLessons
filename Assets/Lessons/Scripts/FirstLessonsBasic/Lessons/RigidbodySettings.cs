using UnityEngine;

namespace FirstLessonsBasic.Lessons
{
    [CreateAssetMenu(menuName = "Lessons/Lesson1/Control Rigidbody Settings")]
    public class RigidbodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpForce;

        public Vector3 JumpForce => _jumpForce;
    }
}
