using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    private Rigidbody rb;
    private float timer = 0.2f;
    private float elapsedTime = 1f;
    private float elapsedTime2 = 1f;
    float percentageComplete;
    private Vector3 scale;
    private Vector3 bScale;
    bool  lerped = true;

    public GameObject ball;

    private void Awake()
    {
        scale = transform.localScale;
        bScale = new Vector3(4f, 1f, 1f);

    }
    private void Start()
    {
        if (ball.GetComponent<Rigidbody>())
        {
            rb = ball.GetComponent<Rigidbody>();
            Debug.Log("Yeeeehaw");
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            elapsedTime = 0;
            lerped = false;
            
            rb.AddForce(transform.right * 10000f);
        }
        if (elapsedTime > timer && lerped == false)
        {
            elapsedTime2 = 0;
            lerped = true;
        }

        elapsedTime += Time.deltaTime;
        elapsedTime2 += Time.deltaTime;
        //float percentageComplete = elapsedTime / timer;

    }

    private void FixedUpdate()
    {
        //float angleRot = animationCurve.Evaluate(timer) * 90f;
        //Vector3 locRot = new Vector3(transform.localRotation.x, -angleRot, transform.localRotation.z);
        //transform.localEulerAngles = locRot;

        float percentageComplete = elapsedTime / timer;
        float percentageComplete2 = elapsedTime2 / timer;
        transform.localScale = Vector3.Lerp(scale, bScale, percentageComplete);
        transform.localScale = Vector3.Lerp(bScale, scale, percentageComplete2);
    }
}
