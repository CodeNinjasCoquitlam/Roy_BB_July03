using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FourWaySplit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y >= 400)
        {
            SceneManager.LoadScene(8);
        }
        if (gameObject.transform.position.y <= -11)
        {
            SceneManager.LoadScene(7);
        }
        if(gameObject.transform.position.x >= 890)
        {
            int level = Random.Range(1, 6);
            SceneManager.LoadScene(level);
        }
    }
}
