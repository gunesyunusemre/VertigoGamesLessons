using System;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Scripts
{
    public class ManagerInitializerMono : MonoBehaviour
    {
        [SerializeField] private AbstractScriptableManagerBase[] _abstractScriptableManagerArray;
        private List<AbstractScriptableManagerBase> _instantiatedAbstractScriptableManagerList;
        void Start()
        {
            _instantiatedAbstractScriptableManagerList = new List<AbstractScriptableManagerBase>(_abstractScriptableManagerArray.Length);
            for (int i = 0; i < _abstractScriptableManagerArray.Length; i++)
            {
                var instantiated = Instantiate(_abstractScriptableManagerArray[i]);
                instantiated.Initialize();
                _instantiatedAbstractScriptableManagerList.Add(instantiated);
            }
        }

        private void OnDestroy()
        {
            if (_instantiatedAbstractScriptableManagerList!=null)
            {
                for (int i = 0; i < _abstractScriptableManagerArray.Length; i++)
                {
                    _abstractScriptableManagerArray[i].Destroy();
                }
            }
            
            
        }
    }
}
