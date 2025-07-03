using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lives : MonoBehaviour
{
    public bool invincibility = false;
    public Text loseLife;
    public GameObject gameOver;
    public static GMS liveScript;
    public int RandomNumber;
    public GameObject[] Enemies;
    public ChestShake chestShake;
    public bool CanTouch = true;
    public int RE;
    private GameObject Enemy;
   
    // Start is called before the first frame update
    void Start()
    {
        CanTouch = true;
    }

    // Update is called once per frame
    void Update()
    {
        loseLife.text = "lives: " + GMS.lives.ToString();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("cactuses"))
        {
            if (!invincibility)
            {
                invincibility = true;
                GMS.lifeLoss(-1);
                Invoke("Inv", 2f);
            }

            if(GMS.lives <= 0)
            {
                SceneManager.LoadScene(14);
            }
        }

        if ((other.gameObject.CompareTag("chest")) && (CanTouch == true))
        {
            CanTouch = false;
            RandomNumber = Random.Range(1, 3);
            if (RandomNumber  == 1)
            {
            GMS.lifeLoss(Random.Range(1, 4));
            }
            else
            {
                RE = Random.Range(0, Enemies.Length);
                Enemy = Instantiate(Enemies[RE], other.gameObject.transform.position, other.gameObject.transform.rotation);
                if(RE <= 4)
                {

                }
            }
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            GMS.lifeLoss(-1);
        }
            
        


    }
    void Inv()
    {
        invincibility = false;
    }
}
