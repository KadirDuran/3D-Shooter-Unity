using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "Shooter/PlayerMovement/Player Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float verticalSpeed=5f;
        public float horizontalSpeed=5f;
    }
}