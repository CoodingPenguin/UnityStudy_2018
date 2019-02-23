using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMovement : MonoBehaviour {
    Vector3 recentMousePosition = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         Vector3 MouseDelta = Input.mousePosition - recentMousePosition;
        transform.Rotate(-MouseDelta.y, 0, 0f, Space.Self);
        transform.Rotate(0, MouseDelta.x, 0f, Space.World);

        recentMousePosition = Input.mousePosition;
	}
}
