using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{

    //instancia a classe Vector que possibilita manipular as dimensões
    public Vector3 m;
    // Start é chamado antes da atualização do primeiro frame
    void Start()
    {
        m.y = 0.0f;
    }
    // Update é chamado a cada atualização de frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m.y = 1f;
            Escala(m);
            m.y = 1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m.y = -1f;
            Escala(m);
            m.y = -1f;
        }

    }
    void Escala(Vector3 m)
    {
        transform.Rotate(m);

    }

}
