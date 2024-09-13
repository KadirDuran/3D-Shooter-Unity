using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.PlayerInput
{

    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData[] _inputArray;
        private void Update()
        {
            for (int i = 0; i < _inputArray.Length; i++)
            {
                _inputArray[i].ProcessInput();
            }
        }
    }
}