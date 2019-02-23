using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAndJump : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.W))
        {
            transform.Translate(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(prefab);
        }
	}

    void OnTriggerEnter(Collider c)
    {
        c.gameObject.GetComponent<Rigidbody>().AddForce(0,10,0);
    }
}
