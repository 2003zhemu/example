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
        Invoke("siwang", 1f);//�ӳ�һ���ִ��siwang����
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;//�ӵ�����
    }
    public void siwang()//���ɱ�ըЧ����ͬʱɾ���ӵ�
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
