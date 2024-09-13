using Shooter.PlayerControls;
using Shooter.PlayerInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.PlayerRotation
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] InputData _rotationInputData;
        [SerializeField] private Transform _towerTransform;
        [SerializeField] private TowerRotationSettings _towerRotationSettings;

        private void Update()
        {
             _towerTransform.Rotate(0,_rotationInputData.Horizontal*_towerRotationSettings.TowerRotationSpeed , 0,Space.Self);
        }
    }
}