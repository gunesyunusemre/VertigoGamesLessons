using UnityEngine;

namespace FirstLessonsBasic.Lessons
{
    [CreateAssetMenu(menuName = "Lessons/Lesson1/Rotate Settings")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 1f;
        public float Speed => _speed;
    }
}
