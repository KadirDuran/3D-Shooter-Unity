using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lessons //namespace scriptleri sýnýflandýrmaya yarar.
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSettings _rotateSettings;
        void Update()
        {
            transform.Rotate(Vector3.up, _rotateSettings.Speed * Time.deltaTime); // Time.deltatime frame eþitlemek için kullanýldý.
                
        }
    }
}