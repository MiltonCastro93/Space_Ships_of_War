using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    //Ejes Right = 90; 90; 60
    //Ejes Left = -90; 90; 60

    public GameObject[] prefabsShips;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CrearEnemigos(3);
        }
    }

    public void CrearEnemigos(int total) {
        for(int i = 0; i < total; i++) {
            GameObject ships = Instantiate(prefabsShips[Random.RandomRange(0, prefabsShips.Length)], new Vector3(Random.RandomRange(-90f, 90f), 90f, 60), Quaternion.identity);

        }

    }

}
