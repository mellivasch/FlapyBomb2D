using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {

    public GameObject bomb;
    float spawnTime = 0.5f;

   void Start ()
   {
        StartCoroutine(Spawn ());
   }
    

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.3f, 2.3f), 5.6f), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
   

}
