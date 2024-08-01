using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidanfashe : MonoBehaviour
{
    public GameObject zidan;
    public GameObject texiao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void zdfs()
    {
        GameObject hj=Instantiate(zidan,transform.position,Quaternion.identity);
        hj.transform.rotation = Quaternion.FromToRotation(-hj.transform.up,transform.up);
        texiao.SetActive(true);
        Invoke("texiaoguanbi", 0.2f);
    }//生成子弹和显示开火效果，以及0.2f后取消开火效果
    public void texiaoguanbi()
    {
        texiao.SetActive(false);
    }//隐藏开火效果

}
