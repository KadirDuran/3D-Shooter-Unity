using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.PlayerControls
{
    [CreateAssetMenu(menuName = "Shooter/Player/Tower Rotation Setting")]
    public class TowerRotationSettings : ScriptableObject
    {
        public float TowerRotationSpeed = 1f;
    }
}