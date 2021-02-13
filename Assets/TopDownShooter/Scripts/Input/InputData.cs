using UnityEngine;

namespace TopDownShooter.Scripts.Input
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
    }
}
