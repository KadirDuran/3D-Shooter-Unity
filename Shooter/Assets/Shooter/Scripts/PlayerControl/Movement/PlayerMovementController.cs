using Shooter.PlayerInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] InputData _inputData;
        [SerializeField] Rigidbody _rigidbody;
        [SerializeField] Transform _targetTransform;
        [SerializeField] PlayerMovementSettings _playerMovementSettings;
        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+ (_rigidbody.transform.forward*_inputData.Vertical*_playerMovementSettings.verticalSpeed));
            _targetTransform.Rotate(0f,_inputData.Horizontal * _playerMovementSettings.horizontalSpeed, 0f, Space.Self);
        }
    }
}