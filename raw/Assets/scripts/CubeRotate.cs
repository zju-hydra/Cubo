﻿using UnityEngine;
using System.Collections;

public class CubeRotate : MonoBehaviour {
	Vector3 StartPosition;
	Vector3 previousPosition;
	Vector3 offset;
	Vector3 finalOffset;
	Vector3 eulerAngle;
	
	float angle;
	
	void Start()
	{
		
	}
	
	
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			StartPosition = Input.mousePosition;
			previousPosition = Input.mousePosition;
		}
		if (Input.GetMouseButton(0))
		{
			offset = Input.mousePosition - previousPosition;
			previousPosition = Input.mousePosition;
			transform.Rotate(Vector3.Cross(offset, Vector3.forward).normalized, offset.magnitude, Space.World);
		}
		if (Input.GetMouseButtonUp(0))
		{
			finalOffset = Input.mousePosition - StartPosition;
			angle = finalOffset.magnitude;
		}

		if (angle > 0)
		{
			angle -= 5;
			transform.Rotate (Vector3.down * 5.0f * Time.deltaTime * angle);
		}
		else
		{
			transform.Rotate (Vector3.down * 5.0f * Time.deltaTime);
		}
	}
}