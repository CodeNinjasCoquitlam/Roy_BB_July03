using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    private bool InvOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (InvOn)
            {
                inventory.SetActive(false);
                InvOn = false;
            }
            else
            {
                inventory.SetActive(true);
                InvOn = true;
            }
            
        }
    }
}
