using UnityEngine;

namespace TopDownShooter.Scripts.Input
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;

        [Header("Axis Base Control")] 
        [SerializeField] private bool _axisActive;
        [SerializeField] private string AxisNameHorizontal;
        [SerializeField] private string AxisNameVertical;

        [Header("Key Base Control")] 
        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode PositiveHorizontalKeyCode;
        [SerializeField] private KeyCode NegativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode PositiveVerticalKeyCode;
        [SerializeField] private KeyCode NegativeVerticalKeyCode;
        [SerializeField] private float _increaseAmount=1f;

        public void ProcessInput()
        {
            if (_axisActive)
            {
                Horizontal = UnityEngine.Input.GetAxis("Horizontal");
                Vertical = UnityEngine.Input.GetAxis("Vertical");
            }
            else
            {
                if (_keyBaseHorizontalActive)
                {
                    KeyBaseActiveControl(ref Horizontal,PositiveHorizontalKeyCode, NegativeHorizontalKeyCode);
                }
                if (_keyBaseVerticalActive)
                {
                    KeyBaseActiveControl(ref Vertical, PositiveVerticalKeyCode, NegativeVerticalKeyCode);
                }
            }
        }

        private void KeyBaseActiveControl(ref float value, KeyCode positive, KeyCode negative)
        {
            bool positiveActive = UnityEngine.Input.GetKey(positive);
            bool negativeActive = UnityEngine.Input.GetKey(negative);
            if (positiveActive)
            {
                value += _increaseAmount;
            }
            else if (negativeActive)
            {
                value -= _increaseAmount;
            }
            else
            {
                value = 0;
            }

            value=Mathf.Clamp(value, -1, 1);
        }
        
    }
}
