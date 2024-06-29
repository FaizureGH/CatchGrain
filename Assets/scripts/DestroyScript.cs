using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Sparrow")
        {
            Destroy(gameObject);
            Debug.Log("Grain consumed!");
        }
        else  if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            Debug.Log("Grain destroyed!");
        }
        else
        {
            Destroy(gameObject, 5f);
            SceneManager.LoadSceneAsync("GameOver");
            Debug.Log("gameOver");

        }
    }

}
