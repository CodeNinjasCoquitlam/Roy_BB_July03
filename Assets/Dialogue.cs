using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    string[] names = new string[] { "Hey!", "Who are you?", "No time for introduction.", "Take 5 lives and leave.", "You want more?", "Fine. 8 lives. That's all.", "Now LEAVE!" };
    public Text changeText;
    public int checkElement = 0;
    public bool InDialogue;
    public GameObject Exclamation;

    // Start is called before the first frame update
    void Start()
    {
        changeText.text = names[checkElement];
        InDialogue = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            checkElement++;
            Exclamation.SetActive(false);
        }

        changeText.text = names[checkElement];

    }
}
