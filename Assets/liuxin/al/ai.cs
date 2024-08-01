using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
    public float speed=2;
    public float rata=60;
    public List<Vector3> paokouweizh=new List<Vector3>();
    public GameObject qinagkou1;
    public GameObject qinagkou2;
    public GameObject qinagkou3;
    float timemax = 1f;
    float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        yidon();
        fashe();
    }
    public void yidon()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.position += -transform.up * y * speed * Time.deltaTime;
        transform.Rotate(0, 0, -1 * rata * x * Time.deltaTime);
    }//物体的移动
    public void fashe()
    {
        time += Time.deltaTime;
        if (time > timemax&&Input.GetKey(KeyCode.F))
        {
            if (qinagkou1!=null)
            {
                qinagkou1.GetComponent<zidanfashe>().zdfs();
            }
            if (qinagkou2 != null)
            {
                qinagkou2.GetComponent<zidanfashe>().zdfs();
            }
            if (qinagkou3 != null)
            {
                qinagkou3.GetComponent<zidanfashe>().zdfs();
            }
            time = 0;
        }
    }//发射子弹命令
}
