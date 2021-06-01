using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    //instancia a classe Vector que possibilita manipular as dimensões
    public Vector3 scaleChange;





    // Start é chamado antes da atualização do primeiro frame
    void Start()
    {
      
    }

    // Update é chamado a cada atualização de frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float x = 0.01f;
            float y = 0.01f;
            float z = 0.01f;
            scaleChange.Set(x, y, z);
            Escala();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float x = -0.01f;
            float y = -0.01f;
            float z = -0.01f;
            scaleChange.Set(x, y, z);
            Escala();
        }

    }

    void Escala()
    {
      
            transform.localScale += scaleChange;
      

    }

}

