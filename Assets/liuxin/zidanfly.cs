using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidanfly : MonoBehaviour
{
    public float speed;
    public GameObject baozha;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("siwang", 1f);//延迟一秒后执行siwang方法
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;//子弹飞行
    }
    public void siwang()//生成爆炸效果，同时删除子弹
    {
        Instantiate(baozha, transform.position, Quaternion.identity);
        Destroy(gameObject); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jianzhuwu"))
        {
            siwang();
        }
    }
}
