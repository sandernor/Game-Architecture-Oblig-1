using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject raindrop;
    [SerializeField] private Vector3 spawnSize = new Vector3(25f, 3f, 25f);

    Vector3 GetRandRainPos()
    {
        float x = Random.Range(-spawnSize.x, spawnSize.x);
        float z = Random.Range(-spawnSize.z, spawnSize.z);
        float y = Random.Range(-spawnSize.y, spawnSize.y);

        Vector3 position = transform.position;
        position.x = x;
        position.z = z;
        position.y = y;
        return position;
    }

    void SpawnRain()
    {
        GameObject raindropthing = Instantiate(raindrop, GetRandRainPos(), Quaternion.identity);

        Destroy(raindropthing, 4f);
    }
    private void Start()
    {
        InvokeRepeating("SpawnRain", 0.1f, 0.1f);

        //for (int i = 0; i < 100; i++)
        //{
        //    SpawnRain();
        //}
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, spawnSize*2);
    }

    //// Start is called before the first frame update
    //void Start()
    //{
    //    for (int i = 0; i < 100; i++)
    //    {
    //        Instantiate(raindrop, transform.position, Quaternion.identity);
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
