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
    //�����ӵ��ķ���
    public void Launch(Vector2 direction,float force)//�������
    {
        rigidbody2d.AddForce(direction*force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"�ӵ���ײ����:{collision.gameObject}");//����
        Destroy(gameObject);//��ײ�������ӵ�
    }
}
