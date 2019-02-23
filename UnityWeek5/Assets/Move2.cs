using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(MoveRight());
	}
	
    
    IEnumerator MoveRight()
    {
        while (true)
        {
            transform.Translate(Time.deltaTime, 0, 0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yield return StartCoroutine(MoveLeft());    // MoveLeft끝날 때까지 기다림
            }
            yield return null; // 한 프레임 기다림
        }
       
    }

    IEnumerator MoveLeft()
    {
        float timer = 0;
        while (true)
        {
            transform.Translate(-Time.deltaTime, 0, 0);
            timer += Time.deltaTime;
            if (timer > 1) break;
            yield return null;
        }

    }
}
