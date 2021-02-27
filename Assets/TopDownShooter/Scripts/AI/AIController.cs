using System;
using System.Collections.Generic;
using TopDownShooter.Scripts.Input;
using TopDownShooter.Scripts.Inventory;
using TopDownShooter.Scripts.PlayerControl;
using UniRx;
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


        public List<AITarget> TargetsList;
        private CompositeDisposable _targetDispose;
        private void Awake()
        {
            //creating new one
            _aiMovementInput = Instantiate(_aiMovementInput);
            _aiRotationInput = Instantiate(_aiRotationInput);
            
            _playerMovementController.InitializeInput(_aiMovementInput);
            _towerRotationController.InitializeInput(_aiRotationInput);
            
            UpdateTarget();
        }

        public void UpdateTarget()
        {
            Vector3 targetMovementPosition = transform.position+((TargetsList[0].transform.position - transform.position).normalized *
                                             (Vector3.Distance(TargetsList[0].transform.position,transform.position)-5f));
            
            _aiMovementInput.SetTarget(transform, targetMovementPosition);
            _aiRotationInput.SetTarget(_towerRotationController.TowerTransform, 
                TargetsList[0].transform.position);

            _targetDispose = new CompositeDisposable();
            TargetsList[0].onDeath.Subscribe(OnTargetDeath).AddTo(_targetDispose);
        }

        private void OnTargetDeath(Unit obj)
        {
            Debug.Log("Target is Death");
            _targetDispose.Dispose();
            TargetsList.RemoveAt(0);

            if (TargetsList.Count>0)
            {
                UpdateTarget();
            }
            else
            {
                this.enabled = false;
            }
        }
        
        private void Update()
        {
            
            
            _aiMovementInput.ProcessInput();
            _aiRotationInput.ProcessInput();

            if (_aiRotationInput.Horizontal<0.05f)
            {
                _inventoryController.ReactiveShootCommand.Execute();
            }
            
        }
    }
}
