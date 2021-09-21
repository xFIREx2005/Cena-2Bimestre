using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	Vector3 m;

	Player player = new Player(0.08f, 0.2f,2.5f,0.01f);

	void Update()
    {
        Teclas();
    }

	void Teclas()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			if(transform.position.y<=4){
			m.y = player.jump;
			Movimento(m);			
			m.y = 0.0f;
			}
		}
		if (Input.GetKey(KeyCode.W))
		{
			m.x = player.speed;
			Movimento(m);		
			m.x = 0.0f;
		}
		if (Input.GetKey(KeyCode.S))
		{

			m.x = -player.speed;
			Movimento(m);	
			m.x = 0.0f;

		}
		if (Input.GetKey(KeyCode.D))
		{
			m.z = -player.speed;
			Movimento(m);
			m.z = 0.0f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			m.z = player.speed;
			Movimento(m);
			m.z = 0f;
		}
		

	}
	void Movimento(Vector3 m)
	{
		transform.Translate(m);
	}	
}
