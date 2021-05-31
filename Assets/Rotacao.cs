using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
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

		isLeftButtonDown = Input.GetMouseButtonDown(0);
		isRightButtonDown = Input.GetMouseButtonDown(1);
		isMiddleButtonDown = Input.GetMouseButtonDown(2);
		
		if (isLeftButtonDown)
		{
			m.x = -30f;
			Rodar(m);
			isLeftButtonDown = false;
		}

		if (isRightButtonDown)
		{
			m.x = 30f;
			Rodar(m);
			isLeftButtonDown = false;
		}






	}

	void Rodar(Vector3 x)
	{
		transform.Rotate(x);
	}

}
