using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class world : MonoBehaviour
{
    public GameObject Zhangaiwu;
    float CloneX;
    float CloneY;

    [SerializeField] private Sprite dixin1;//ͼƬ1
    [SerializeField] private Sprite dixin2;//ͼƬ2
    [SerializeField] private Sprite dixin3;//ͼƬ3
    private Dictionary<Vector2,GameObject> hanjindaxiao=new Dictionary<Vector2, GameObject>();//��λ���������
    // ---------------------------------------------------
 
    // Start is called before the first frame update
    void Start()
    {
        world_shengcheng(20, 20);
        world_zhangaiWu();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void world_shengcheng(int chang,int kuan)
    {
        Camera.main.transform.position = new Vector3(chang / 2, kuan / 2, Camera.main.transform.position.z);//���������λ��
        for (int x = 0; x <= chang; x++)
        {
            for (int y = 0; y <= kuan; y++)
            {
                GameObject hj = new GameObject();//��������
                SpriteRenderer tu=hj.AddComponent<SpriteRenderer>();//���������SpriteRenderer���������ʾͼƬ
                hj.transform.parent = transform;//��������Ϊ��ǰ�ű����صĶ�����Ӽ�
                hj.transform.position = new Vector2(x, y);//��������λ��
                hj.name = "vector" + x + "--" + y;//Ϊ��������
                hanjindaxiao[new Vector2(x, y)] = hj;//�ֵ������
                if (x > chang / 2)
                {
                    tu.sprite = dixin2;
                }
                if (x == chang / 2)
                {
                    tu.sprite = dixin3;
                }
                if (x < chang / 2)
                {
                    tu.sprite = dixin1;
                }
            }
        }
    }
    //��������ϰ���ķ���
    private void world_zhangaiWu()
    {
        //����һ����ά���飬���ɡ�
        //���ɵ�����
        List<Vector2> TempP= new List<Vector2>();

        Debug.Log("���������");
        for (int i=1; i<20; i++) {
            CloneX = Random.Range(1f, 20f);
            CloneY = Random.Range(1f, 20f);
            Vector2 TempPos = new Vector2(CloneX, CloneY);

            if (!TempP.Contains(TempPos)) {
                GameObject hj = Instantiate(Zhangaiwu);

                Debug.Log("�������" + TempPos);
                hj.transform.position = TempPos;
                TempP.Add(TempPos);
            }
            
        }
    }
}
