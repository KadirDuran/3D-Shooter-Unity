using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtStat : MonoBehaviour
{
    private float Healt = 100;
    public void Hit(float damage)
    {
        Healt-=damage;
        if (Healt <= 0)
        {
            Debug.Log("Healt Zero");
        }
        else
        {
            Debug.Log("Healt : " + Healt.ToString());
        }
    }
}
