using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boxTilt : MonoBehaviour {


	void OnMouseDown(){
		transform.Rotate(new Vector3 (40, 0, 0) * Time.deltaTime);
	}
}
