using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipsCc : MonoBehaviour {
    public float speed = 1f;

    private Rigidbody rb;
    private CharacterController characterController;

    public float anguleMax = 45f;
    public float timeCurrent = 0f, timeMax = 2f;

    void Start() {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

    }


    void Update() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        characterController.Move(new Vector3(x, y, 0f) * speed * Time.deltaTime);

        if(x != 0f) {
            timeCurrent += Time.deltaTime;
            timeCurrent = Mathf.Clamp(timeCurrent, 0f, timeMax);
            float porcen = timeCurrent / timeMax;

            transform.localRotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(0f, 0f, anguleMax * -x), porcen);
        }

    }

}

