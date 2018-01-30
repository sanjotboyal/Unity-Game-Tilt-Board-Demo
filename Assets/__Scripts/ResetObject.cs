using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour {
	private Vector3 initialPosition;
	private Quaternion initialRotation;
	// Use this for initialization
	void Start () {
		initialPosition = gameObject.transform.position;
		initialRotation = gameObject.transform.rotation;
	}
	
	void OnMouseDown(){
		gameObject.transform.position = initialPosition;
		gameObject.transform.rotation = initialRotation;
	}
}
