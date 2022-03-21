using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MoveEnemy : MonoBehaviour {
    // Use this for initialization
    public float speed = 3f;
    private bool movingRight = true;
    public float left;
    public float right;

    void Start () {
 
    }
    
    // Update is called once per frame
    void FixedUpdate ()
    {
    //假设我在x轴-5到5之间左右循环移动
        if(movingRight)
        {
            //我正在右移
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
 
            //如果我移到了5，那么接下来就是左移，所以把右移设为false
            if (transform.position.x >= right)
            {
                movingRight = false;
                transform.rotation=Quaternion.Euler(0,-90,0);
            }
        }
        else
        {
            //当我在左移，而且x轴坐标到了-5，说明结束左移，开始右移
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
 
            //左移结束，右移开始，设置状态为true
            if (transform.position.x <= left)
            {
                movingRight = true;
                transform.rotation=Quaternion.Euler(0,90,0);
            }
        }
    }
}
