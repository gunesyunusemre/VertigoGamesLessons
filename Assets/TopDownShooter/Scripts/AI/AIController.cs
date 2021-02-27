using System;
using TopDownShooter.Scripts.Input;
using TopDownShooter.Scripts.Inventory;
using TopDownShooter.Scripts.PlayerControl;
using UnityEngine;

namespace TopDownShooter.Scripts.AI
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] private InputDataAI _aiMovementInput;
        [SerializeField] private InputDataAI _aiRotationInput;
        [SerializeField] private PlayerMovementController _playerMovementController;
        [SerializeField] private TowerRotationController _towerRotationController;
        [SerializeField] private PlayerInventoryController _inventoryController;


        public Transform target;
        private void Awake()
        {
            //creating new one
            _aiMovementInput = Instantiate(_aiMovementInput);
            _aiRotationInput = Instantiate(_aiRotationInput);
            
            _playerMovementController.InitializeInput(_aiMovementInput);
            _towerRotationController.InitializeInput(_aiRotationInput);
            
            
        }

        private void Update()
        {
            _aiMovementInput.SetTarget(transform, target.position);
            _aiRotationInput.SetTarget(transform, target.position);
            
            _aiMovementInput.ProcessInput();
            _aiRotationInput.ProcessInput();
        }
    }
}
