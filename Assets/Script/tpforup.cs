using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tpforup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= 11.6)
        {
            int level = Random.Range(1, 5);
            SceneManager.LoadScene(level);
        }

        if (gameObject.transform.position.x <= -11.65)
        {
            int level = Random.Range(1, 5);
            SceneManager.LoadScene(level);
        }
        if (gameObject.transform.position.y <= -5.12)
        {
            SceneManager.LoadScene(2);
        }
    }
}
