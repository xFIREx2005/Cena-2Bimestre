using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    public Vector3 m;
    Player player = new Player(0.08f, 0.2f,2.5f,0.01f);
    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m.y = player.rotacao;
            Escala(m);
            m.y = 1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m.y = -player.rotacao;
            Escala(m);
            m.y = -1f;
        }

    }
    void Escala(Vector3 m)
    {
        transform.Rotate(m);

    }

}
