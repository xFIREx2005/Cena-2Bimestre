using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public Vector3 scaleChange;
    Player player = new Player(0.08f, 0.2f,2.5f,0.01f); 
 

    // Update é chamado a cada atualização de frame
    void Update()
    {
        if (transform.localScale.y <= 2.5f)
         if (Input.GetKey(KeyCode.UpArrow)) 
         Aumentar();

        if (transform.localScale.y >= 0.2f)
        if (Input.GetKey(KeyCode.DownArrow))
        Diminuir();

    }

    void Aumentar()
    {
        float x = player.escala;
        float y = player.escala;
        float z = player.escala;
        scaleChange.Set(x, y, z);
        Escala();
    }

    void Diminuir()
    {
        float x = -player.escala;
        float y = -player.escala;
        float z = -player.escala;
        scaleChange.Set(x, y, z);
        Escala();
    }

    void Escala()
    { 
            transform.localScale += scaleChange;  
    }

}

