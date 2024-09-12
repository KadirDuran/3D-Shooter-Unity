using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shooter.PlayerInput
{
    [CreateAssetMenu(menuName = "Shooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Vertical;
        public float Horizontal;
    }
}