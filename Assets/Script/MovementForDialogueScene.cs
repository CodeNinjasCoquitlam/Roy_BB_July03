using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementForDialogueScene : MonoBehaviour
{

    public float speed = 0.1f;
    public Rigidbody2D rigidbody;
    public Dialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dialogue.InDialogue == false) { 
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rigidbody.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector2.down * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }
    }
}
        
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("chest"))
        {
            GMS.lifeLoss(Random.Range(-5, 5));

            }

        if (other.gameObject.CompareTag("doctorsDesk"))
        {
            GMS.lifeLoss(5);
        }
    }


}
