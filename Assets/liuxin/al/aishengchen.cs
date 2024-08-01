using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;

public class aishengchen : MonoBehaviour
{
    public Sprite shengti1;
    public Sprite shengti2;
    public Sprite shengti3;
    public GameObject qingguan1;
    public GameObject qingguan2;
    public GameObject qingguan3;
    // Start is called before the first frame update
    void Start()
    {
        suijishengchun();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void shencheng(int x,int y,int type,int sum)
    {
        GameObject hj = new GameObject();
        hj.transform.position = new Vector3(x,y,0);
        SpriteRenderer st=hj.AddComponent<SpriteRenderer>();
        st.sortingOrder = 2;
        ai ai = hj.AddComponent<ai>();
        switch (type)
        {
            case 1:
                st.sprite = shengti1;
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x + 0.15f, hj.transform.position.y + 0.015f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x - 0.15f, hj.transform.position.y + 0.015f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x, hj.transform.position.y-0.1f, hj.transform.position.z));
                break;
            case 2:
                st.sprite = shengti2;
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x + 0.15f, hj.transform.position.y + 0.05f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x - 0.15f, hj.transform.position.y + 0.05f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x, hj.transform.position.y, hj.transform.position.z));
                break;
            case 3:
                st.sprite = shengti3;
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x + 0.2f, hj.transform.position.y + 0.05f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x - 0.2f, hj.transform.position.y + 0.05f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x, hj.transform.position.y, hj.transform.position.z));
                break;
                default:
                st.sprite = shengti1;
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x + 0.15f, hj.transform.position.y + 0.05f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x - 0.15f, hj.transform.position.y + 0.05f, hj.transform.position.z));
                ai.paokouweizh.Add(new Vector3(hj.transform.position.x, hj.transform.position.y, hj.transform.position.z));
                break;
        }
        switch (sum)
        {
            case 1:
                ai.qinagkou1 = Instantiate(suijipaokou());
                ai.qinagkou1.transform.position = ai.paokouweizh[2];
                ai.qinagkou1.transform.parent = hj.transform;
                break;
            case 2:
                ai.qinagkou1 = Instantiate(suijipaokou());
                ai.qinagkou2 = Instantiate(suijipaokou());
                ai.qinagkou1.transform.position = ai.paokouweizh[0];
                ai.qinagkou2.transform.position = ai.paokouweizh[1];
                ai.qinagkou1.transform.parent = hj.transform;
                ai.qinagkou2.transform.parent = hj.transform;
                break;
            case 3:
                ai.qinagkou1 = Instantiate(suijipaokou());
                ai.qinagkou2 = Instantiate(suijipaokou());
                ai.qinagkou3 = Instantiate(suijipaokou());
                ai.qinagkou1.transform.position = ai.paokouweizh[0];
                ai.qinagkou2.transform.position = ai.paokouweizh[1];
                ai.qinagkou3.transform.position = ai.paokouweizh[2];
                ai.qinagkou1.transform.parent = hj.transform;
                ai.qinagkou2.transform.parent = hj.transform;
                ai.qinagkou3.transform.parent = hj.transform;
                break;
                default :
                ai.qinagkou1 = Instantiate(suijipaokou());
                ai.qinagkou1.transform.position = ai.paokouweizh[2];
                ai.qinagkou1.transform.parent = hj.transform;
                break;
        }
    }//生成物体，四个参数从左到右前两个是坐标，第三个是坦克的身体，第四个是炮管的数量。炮管使用suijipaokou（）方法随机生成。
    public GameObject suijipaokou()
    {
        int hj = UnityEngine.Random.Range(0, 4);
        switch (hj)
        {
            case 1:
                return qingguan1;
            case 2:
                return qingguan2;
            case 3:
                return qingguan3;
                default:
                return qingguan1;
        }
       
    }//随机生成跑管
    public void suijishengchun()
    {
        int hj = UnityEngine.Random.Range(0, 4);
        int hj2 = UnityEngine.Random.Range(0, 4);
        shencheng(10, 10, hj, hj2);
    }//随机生成物体
}
