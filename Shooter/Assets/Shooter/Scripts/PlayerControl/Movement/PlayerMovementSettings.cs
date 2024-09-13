using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "Shooter/Player/Player Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float verticalSpeed=5f;
        public float horizontalSpeed=5f;
    }
}