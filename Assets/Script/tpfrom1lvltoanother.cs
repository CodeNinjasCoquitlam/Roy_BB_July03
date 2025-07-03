using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tpfrom1lvltoanother : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x >= 877)
        {
        int level = Random.Range(1, 6);
        SceneManager.LoadScene(level);
        }

        

    }
}
