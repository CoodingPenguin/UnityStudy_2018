using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour {

    Vector3 recentMousePosition = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 MouseDelta = Input.mousePosition - recentMousePosition;

        recentMousePosition = Input.mousePosition;
	}
}
