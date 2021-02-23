using System;
using TopDownShooter.Scripts.Input;
using TopDownShooter.Scripts.Inventory;
using UnityEngine;

namespace TopDownShooter.Scripts.PlayerControl
{
    public class LocalPlayerController : MonoBehaviour
    {
        [SerializeField]private PlayerInventoryController _InventoryController;
        [SerializeField] private InputData _shootInput;

        private void Update()
        {
            if (_shootInput.Horizontal > 0)
            {
                _InventoryController.ReactiveShootCommand.Execute();
            }
        }
    }
}
