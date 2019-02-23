using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    
	void Start () {
        StartCoroutine(MoveFunc());
	}

    // return은 여기서부터 다시 시작이야! 이런 뜻 언제마다? 매 프레임마다
    IEnumerator MoveFunc()
    {
        float timer = 0;    // 몇 초가 지났는지를 저장하는 변수
        while (true)
        {
            while (true)
            {
                timer += Time.deltaTime;
                transform.Translate(Time.deltaTime, 0, 0);

                if (timer > 1)
                {
                    timer = 0;
                    break;
                }
                yield return null;
            }

            while (true)
            {
                timer += Time.deltaTime;
                transform.Translate(-Time.deltaTime, 0, 0);

                if (timer > 1)
                {
                    timer = 0;
                    break;
                }
                yield return null;
            }
        }
        
    }
}
