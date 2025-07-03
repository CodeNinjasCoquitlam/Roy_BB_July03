using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealMyPlayerPond : MonoBehaviour
{
    public bool healOnce = false; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Player") && healOnce == false)
        {
            GMS.lifeLoss(3);
            healOnce = true;
        }
    }
 }
