using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviour : MonoBehaviour {

    void Start()
    {
        // Fuction();   // 이게 아니라
        StartCoroutine(Function1());
    }

    // 우리가 아는 함수는 시작점이 body의 첫 부분
    // 함수 시작점이 여러 곳
    // 재귀함수랑 헷갈리지 말 것
    // 뭔가 지연을 주고 싶을 때 사용
    IEnumerator Function1(){
        // 1
        Debug.Log("A");
        yield return new WaitForSeconds(1f);    // 1초를 기다린 뒤에 이 함수를 실행

        //2

        Debug.Log("B");
        yield return new WaitForSeconds(1f);

        yield return new WaitForSeconds(1f);

        //3

        Debug.Log("C");
    }
    

    IEnumerator Function2()
    {
        while (true)
        {
            Debug.Log("A");
            yield return null;
        }
        
    }

    // Update에서 A출력하는 것과 동일
    

}
