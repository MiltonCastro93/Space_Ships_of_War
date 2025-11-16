using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    private float Hit = 15f;


    public void DestroyMe(float time) {
        print("Inicio");
        Destroy(gameObject,time);
    }



    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Side (3)") {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy")) {
            //llamar a su funcion de impacto
        }

    }


}
