using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attatch to GameObjects that kill enemies
public class DestroyEnemy : MonoBehaviour
{
    public void OnTriggerEnter(Collider myCol)
    {
        if (myCol.gameObject.tag == "Enemy") {
            Destroy(myCol.gameObject);
        }
    }
}
