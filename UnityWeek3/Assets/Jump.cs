using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    Rigidbody r;
    int myState = 0;
    int count = 0;
	// Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && (myState == 0 || count <= 1))
        {
            r.velocity = new Vector3(0, 5, 0);
            count++;
        }
	}

    void OnCollisionEnter(Collision c)
    {
        print("Enter");
        myState = 0;
        count = 0;
    }

    void OnCollisionExit(Collision c)
    {
        print("Exit");
        myState = 1;
    }
}
