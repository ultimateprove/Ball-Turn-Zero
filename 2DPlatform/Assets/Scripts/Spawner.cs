using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
   public Transform spawnPos;
   [SerializeField] Vector2 range;
   [SerializeField] GameObject unit;

    private void Start() {
        StartCoroutine(Spawn());
    }

   IEnumerator Spawn()
   {
       yield return new WaitForSeconds(1);
       Vector2 pos = spawnPos.position + new Vector3 (0,Random.Range(-range.y,range.y));
       Instantiate(unit, pos, Quaternion.identity);
       Repeat();
   }

   void Repeat()
   {
      StartCoroutine(Spawn());
   }
   
}
