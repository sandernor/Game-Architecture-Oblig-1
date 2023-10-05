using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class Flipper : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            timer = 0;
        }

        timer += Time.deltaTime;

    }

    private void FixedUpdate()
    {
        
        rb.MoveRotation(inRot * Quaternion.Euler(inRot.x, inRot.y, -animationCurve.Evaluate(timer) * 45f));
    }

}
