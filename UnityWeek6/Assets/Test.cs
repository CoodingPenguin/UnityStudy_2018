using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    float blinkSpeed = 1;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(BlinkFunction());
        StartCoroutine(SpeedModRoutine());
    }

    IEnumerator BlinkFunction()
    {
        float alpha = 1;
        while (true)
        {
            while (true)
            {
                alpha += Time.deltaTime * blinkSpeed;
                spriteRenderer.color = new Color(1, 1, 1, alpha);
                if (alpha > 1)
                {
                    break;
                }
                yield return null;
            }
            while (true)
            {
                alpha -= Time.deltaTime * blinkSpeed;
                spriteRenderer.color = new Color(1, 1, 1, alpha);
                if (alpha < 0)
                {
                    break;
                }
                yield return null;
            }

        }
    }

    // 계속 speed 올라감
    IEnumerator SpeedModRoutine()
    {
        while (true)
        {
            blinkSpeed += Time.deltaTime;
            if(blinkSpeed > 10)
            {
                blinkSpeed = 10;
                break;
            }
            yield return null;
        }
    }



}
