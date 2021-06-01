using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	bool isLeftButtonDown;
	bool isRightButtonDown;
	bool isMiddleButtonDown;
	Vector3 m;
	// Start is called before the first frame update
	void Start()
	{
		isLeftButtonDown = false;
		isRightButtonDown = false;
		isMiddleButtonDown = false;
		m.x = 0.0f;
		m.y = 0.0f;
		m.z = 0.0f;
	}

	// Update is called once per frame
	void Update()

	{
		if (Input.GetKey(KeyCode.Space))
		{
			m.y = 0.05f;
			Movimento(m);
			LogMessage("cima");
			m.y = 0.0f;
		}
		if (Input.GetKey(KeyCode.W))
		{
			m.x = 0.05f;
			Movimento(m);
			LogMessage("frente");
			m.x = 0.0f;
		}
		if (Input.GetKey(KeyCode.S))
		{

			m.x = -0.05f;
			Movimento(m);
			LogMessage("atras");
			m.x = 0.0f;

		}
		if (Input.GetKey(KeyCode.D))
		{
			m.z = -0.05f;
			Movimento(m);
			LogMessage("direita");
			m.z = 0.0f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			m.z = 0.05f;
			Movimento(m);
			LogMessage("esquerda");
			m.z = 0f;
		}
		

	}

	void Movimento(Vector3 m)
	{
		transform.Translate(m);

	}

	void LogMessage(string msg)
	{

		Debug.Log("A opção selecionada foi " + msg.ToUpper());
	}
}
