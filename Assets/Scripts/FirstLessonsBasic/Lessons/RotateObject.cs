using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private float _speed = 1f;

        private void Update()
        {
            transform.Rotate(Vector3.up, _speed*Time.deltaTime);
        }
    }
}


