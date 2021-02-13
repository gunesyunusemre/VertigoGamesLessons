using UnityEngine;

namespace FirstLessonsBasic.Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSettings _rotateSettings;
        private void Update()
        {
            transform.Rotate(Vector3.up, _rotateSettings.Speed*Time.deltaTime);
        }
    }
}


