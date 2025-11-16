using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShips : MonoBehaviour {//Codigo desechado
    public float speed = 1f;
    public float LimitedMax = 110f;

    private Rigidbody rb;
    private Vector3 vectorZero;

    private Vector3 ultimatePos = Vector3.zero;
    private float distance = 0f;
    public float current, maxCurrent;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        vectorZero = transform.position;
    }


    void Update() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        distance = Vector3.Distance(vectorZero, new Vector3(transform.position.x,0f,0f));



        if(distance < LimitedMax )
        {
            current = 0f;
            rb.MovePosition(transform.position + new Vector3(x, y, 0f) * speed * Time.deltaTime);
        }
        else
        {
            current += Time.deltaTime;
            current = Mathf.Clamp(current, 0f, maxCurrent);
            float porcen = current / maxCurrent;
            rb.MovePosition(Vector3.Lerp(transform.position, ultimatePos, porcen));
            print("fuera" + distance);
        }

    }

    private void LateUpdate()
    {
        if(distance < LimitedMax)
        {
            ultimatePos = transform.position;
        }
    }

}
