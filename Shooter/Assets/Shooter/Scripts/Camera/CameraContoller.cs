using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.Camera
{
    public class CameraContoller : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _rotationTarget;
        [SerializeField] private Transform _positionTarget;
        [SerializeField] private Transform _cameraTransform;

        private void Update()
        {
            CameraMovementFollow();
            CameraRotationFollow();
        }

        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_rotationTarget.forward), Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }


        private void CameraMovementFollow()
        {
            Vector3 offset = (_cameraTransform.right * _cameraSettings.PositionOffset.x) + (_cameraTransform.up * _cameraSettings.PositionOffset.y) +
                 (_cameraTransform.forward * _cameraSettings.PositionOffset.z);
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, _positionTarget.position + offset, Time.deltaTime * _cameraSettings.PositionLerp);
            
        }

    }
}