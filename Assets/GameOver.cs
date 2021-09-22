using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string NomeDaCena;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision Colider)
    {
        if (Colider.gameObject.tag == "Respawn")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

         if (Colider.gameObject.tag == "Finish")
        {
                SceneManager.LoadScene(NomeDaCena);
        }
    }
}
