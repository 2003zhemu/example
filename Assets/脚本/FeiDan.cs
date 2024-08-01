using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeiDan : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //发射子弹的方法
    public void Launch(Vector2 direction,float force)//方向和力
    {
        rigidbody2d.AddForce(direction*force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"子弹碰撞到了:{collision.gameObject}");//测试
        Destroy(gameObject);//碰撞后消除子弹
    }
}
