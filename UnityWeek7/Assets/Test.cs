using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().Play("Idle");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Animator>().Play("Walk");
        }
	}
}
