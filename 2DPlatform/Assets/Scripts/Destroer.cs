using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroer : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
       if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Bonus"))
       {
           Destroy(other.gameObject);
       }
   }
}
