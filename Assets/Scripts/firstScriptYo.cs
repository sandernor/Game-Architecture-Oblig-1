using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScriptYo : MonoBehaviour
{
    //Movement
    float x;
    float y;
    public float z;
    public float speed = 5;

    //Camera
    float camX;
    float camY;
    [SerializeField] float sens = 500;
    public GameObject cam;

    //public float xSpeed;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("speedChange", 0.1f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, y, z);

        camX = Input.GetAxis("Mouse X") * Time.deltaTime * sens;
        camY = Input.GetAxis("Mouse Y") * Time.deltaTime * sens;
        transform.Rotate(0, camX, 0);
        cam.transform.RotateAround(transform.position, transform.right, -camY);
        //cam.transform.Rotate(-camY, 0, 0);
        transform.Translate(x, y, z);
    }

    //void speedChange()
    //{
    //    speed = speed + 5;
    //    if (speed > 15)
    //    {
    //        speed = 5;
    //    }
    //}
}
