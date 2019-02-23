using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) transform.Translate(-0.1f * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(KeyCode.S)) transform.Translate(0.1f * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(KeyCode.A)) transform.Translate(0f, 0f, 0.1f * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Translate(0f, 0f, -0.1f * Time.deltaTime);
	}
}
