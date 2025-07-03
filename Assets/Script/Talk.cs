using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour
{
    public string triggerName = "";
    public GameObject ConvStarter;
    string[] names = new string[] { "Would you like to heal up to 10 lives?"};
    public Text changeText;
    public int checkElement = 0;
    public bool InDialogue;
    public HealingDesk HD;
    public bool Healonce = true;
    public GameObject ShopDia;

    // Start is called before the first frame update
    void Start()
    {
        changeText.text = names[checkElement];
        InDialogue = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Healonce == true)
        {
            if(checkElement < 4)
        {
        if (Input.GetKeyDown("space")) {
            if(triggerName == "The Actual Healer")
            {
                checkElement++;
                ConvStarter.SetActive(true);
            }
        }
        }

        if(checkElement >= 1 && checkElement <= 3)
        {
        changeText.text = names[checkElement - 1];

        }

        if(checkElement >= 2)
        {
            ConvStarter.SetActive(false);
            checkElement = 0;
            GMS.lifeLoss(5);
            Healonce = false;
        }
        }
        
    }


    public void OnMouseButtonDown(GameObject button)
    {
        if (button.CompareTag("Yes"))
        {
            while(GMS.lives < 10)
            {
                GMS.lifeLoss(1);
                
            }
            ConvStarter.SetActive(false);
                Healonce = false;
        }
        if (button.CompareTag("No"))
        {
            ConvStarter.SetActive(false);
            Healonce = false;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ShopDesk"))
        {
            if (Input.GetKeyDown("space"))
            {
               ShopDia.SetActive(true);
            }
            
        }
    }
}
