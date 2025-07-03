using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassInteract : MonoBehaviour
{
    public bool hasTouched = false;
    public GameObject chest;
    public GameObject[] grasses;
    

    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(1, 100) <= 99)
        {
        Instantiate(chest, new Vector3(grasses[Random.Range(0, 7)].transform.position.x -25, grasses[Random.Range(0, 7)].transform.position.y -16, 3), Quaternion.identity);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
