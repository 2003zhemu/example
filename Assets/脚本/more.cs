using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class more : MonoBehaviour
{
    //获取子弹预制件
    public GameObject zhidanPrefab;
    public GameObject fasheDian;
    Rigidbody2D rigidbody2D;
    public float speed;
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {                                                    
        yidon();
        if (Input.GetKeyDown(KeyCode.K)) {
            Launch();
        }
    }
    private void yidon()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.position += transform.up * y * speed * Time.deltaTime;
        transform.Rotate(0, 0, -1*rotation * x * Time.deltaTime);
    }
    void Launch()
    {

        GameObject ZhiDanObject=Instantiate(zhidanPrefab, fasheDian.transform.position,Quaternion.identity);
        FeiDan zhidan =ZhiDanObject.GetComponent<FeiDan>();
        zhidan.Launch(transform.up, 300);
    }
}
