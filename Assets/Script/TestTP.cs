using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestTP : MonoBehaviour
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
            SceneManager.LoadScene(2);
        }
        if (gameObject.transform.position.y <= -5)
        {
            SceneManager.LoadScene(2);
        }
        if (gameObject.transform.position.x >= 877)
        {
            SceneManager.LoadScene(2);
        }
    }
}
