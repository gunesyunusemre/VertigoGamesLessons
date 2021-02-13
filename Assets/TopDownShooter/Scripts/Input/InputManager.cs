using UnityEngine;

namespace TopDownShooter.Scripts.Input
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;

        private void Update()
        {
            _inputData.Horizontal = UnityEngine.Input.GetAxis("Horizontal");
            _inputData.Vertical = UnityEngine.Input.GetAxis("Vertical");
        }
    }
}
