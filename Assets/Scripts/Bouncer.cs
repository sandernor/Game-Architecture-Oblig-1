using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    private Rigidbody rb;
    private float timer = 0.2f;
    private float elapsedTime = 1f;
    private float elapsedTime2 = 1f;
    float percentageComplete;
    private Vector3 scale;
    private Vector3 bScale;
    bool lerped = true;

    public GameObject ball;
    public GameObject scoreCounter;

    private void Awake()
    {
        scale = transform.localScale;
        bScale = new Vector3(2f, 1f, 2f);

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
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    elapsedTime = 0;
        //    lerped = false;

        //    rb.AddForce(new Vector3(transform.position.x - ball.transform.position.x, transform.position.y - ball.transform.position.y, transform.position.z - ball.transform.position.z).normalized * 10000f);
        //}
        //Vector3 distV = new Vector3(ball.transform.position.x - transform.position.x, ball.transform.position.y - transform.position.y, ball.transform.position.z - transform.position.z);
        //float dist = distV.magnitude;
        //if (dist < 5f)
        //{
        //    Debug.Log("MMKAY");
        //    elapsedTime = 0;
        //    lerped = false;

        //    rb.AddForce(new Vector3(transform.position.x - ball.transform.position.x, transform.position.y - ball.transform.position.y, transform.position.z - ball.transform.position.z).normalized * 10000f);
        //}
        if (elapsedTime > timer && lerped == false)
        {
            elapsedTime2 = 0;
            lerped = true;
        }

        elapsedTime += Time.deltaTime;
        elapsedTime2 += Time.deltaTime;
        //float percentageComplete = elapsedTime / timer;

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("MMKAY");
        if (collision.gameObject.name == "Ball (2)")
        {
            elapsedTime = 0;
            lerped = false;

            rb.AddForce(new Vector3(transform.position.x - ball.transform.position.x, transform.position.y - ball.transform.position.y, transform.position.z - ball.transform.position.z).normalized * 30000f);
            scoreCounter.GetComponent<Score>().Bounce();
        }
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
