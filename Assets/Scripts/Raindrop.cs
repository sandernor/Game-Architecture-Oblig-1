using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
    float x;
    float y;
    float z;
    private Vector3 position;
    public Rigidbody rb;
    float dropMass = 200;

    // Start is called before the first frame update
    void Start()
    {
        //x = Random.Range(-25f, 25f);
        //z = Random.Range(-25f, 25f);
        //y = Random.Range(25f, 35f);

        //position = new Vector3(x, y, z);
        //rb.mass = dropMass;
        //transform.Translate(position);

        //instantiate(drop);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
