using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionOutput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Local Position : " + transform.localPosition);
        Debug.Log("Global Position : " + transform.position);
	}
}
