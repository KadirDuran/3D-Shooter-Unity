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
        [SerializeField] PlayerMovementSettings _playerMovementSettings;
        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+ (_rigidbody.transform.forward*_inputData.Vertical*_playerMovementSettings.verticalSpeed));
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.right*_inputData.Horizontal*_playerMovementSettings.horizontalSpeed));
        }
    }
}