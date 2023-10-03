using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class Flipper2 : MonoBehaviour
{
    [SerializeField] private AnimationCurve animationCurve;
    [SerializeField] private Rigidbody rb;
    private float timer = 2f;
    private Quaternion inRot;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inRot = transform.rotation;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            timer = 0;
        }

        timer += Time.deltaTime;

    }

    private void FixedUpdate()
    {
        //float angleRot = animationCurve.Evaluate(timer) * 90f;
        //Vector3 locRot = new Vector3(transform.localRotation.x, -angleRot, transform.localRotation.z);
        //transform.localEulerAngles = locRot;

        rb.MoveRotation(inRot * Quaternion.Euler(inRot.x, inRot.y, animationCurve.Evaluate(timer) * 45f));
    }
}
