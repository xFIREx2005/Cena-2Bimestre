using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public Rigidbody PlayerRigidbody;
	Vector3 m;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
    {
        Teclas();
    }

	void Teclas()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			if(transform.position.y<=4){
			m.y = 0.2f;
			Movimento(m);			
			m.y = 0.0f;
			}
		}
		if (Input.GetKey(KeyCode.W))
		{
			m.x = 0.08f;
			Movimento(m);		
			m.x = 0.0f;
		}
		if (Input.GetKey(KeyCode.S))
		{

			m.x = -0.08f;
			Movimento(m);	
			m.x = 0.0f;

		}
		if (Input.GetKey(KeyCode.D))
		{
			m.z = -0.05f;
			Movimento(m);
			m.z = 0.0f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			m.z = 0.05f;
			Movimento(m);
			m.z = 0f;
		}
		

	}
	void Movimento(Vector3 m)
	{
		transform.Translate(m);
	}
		
	

	
}
