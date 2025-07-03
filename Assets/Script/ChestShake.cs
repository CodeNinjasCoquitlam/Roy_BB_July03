using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestShake : MonoBehaviour
{
    private Vector2 OP;
    private SpriteRenderer SR;
    public bool CanTouch = true;
    public lives Lives;
    
    // Start is called before the first frame update
    void Start()
    {
        OP = gameObject.transform.position;
        SR = GetComponent<SpriteRenderer>();
        Lives = GameObject.FindWithTag("Player").GetComponent<lives>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            if (Lives.CanTouch == true)
        {
            //Lives.CanTouch = false;
            //gameObject.transform.position = new Vector3(415, 120, -0.1f);
            //gameObject.transform.localScale = new Vector3(2100, 2243, 1);
            SR.sortingOrder = 1;
            StartCoroutine(Shake());
        }
        }
        
    }
    IEnumerator Shake()
    {
        float ET = 0f;
        while (ET < 3f)
        {
            if(ET >= 3f)
            {
                Destroy(gameObject);
            }
           
            transform.position = OP + new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
                ET += Time.deltaTime;
            yield return null;

        }
        
    }
}
