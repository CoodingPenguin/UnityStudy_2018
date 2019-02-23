using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour {

    /*
	void Start () {
        StartCoroutine(Idle());
	}

    IEnumerator Idle()
    {

    }
    */

    // while 루프 + yield return null; 써놓고 하자!

    IEnumerator MoveRight()
    {
        float timer = 0;
        while (true)
        {
            transform.Translate(Time.deltaTime, 0, 0);
            timer += Time.deltaTime;

            if(timer < 0.5 && Input.GetKey(KeyCode.RightArrow))
            {
                yield return StartCoroutine(MoveRightFast());
            }
        }
    }

    IEnumerator MoveRightFast()
    {
        while (true)
        {
            transform.Translate(5 * Time.deltaTime, 0, 0);
            yield return null;
        }
    }
}
