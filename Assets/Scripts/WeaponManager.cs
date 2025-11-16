using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject leftAttack;
    public GameObject rightAttack;
    public GameObject proyectilPrefab;
    public float timeDestroy = 5f;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject Target1 = Instantiate(proyectilPrefab, leftAttack.transform.position, Quaternion.identity);
            Target1.GetComponent<HitManager>().DestroyMe(timeDestroy);
            GameObject Target2 =  Instantiate(proyectilPrefab, rightAttack.transform.position, Quaternion.identity);
            Target2.GetComponent<HitManager>().DestroyMe(timeDestroy);

        }
    }


}
