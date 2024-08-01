using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class world : MonoBehaviour
{
    [SerializeField] private Sprite dixin1;//图片1
    [SerializeField] private Sprite dixin2;//图片2
    [SerializeField] private Sprite dixin3;//图片3
    private Dictionary<Vector2,GameObject> hanjindaxiao=new Dictionary<Vector2, GameObject>();//绑定位置与物体的
    // ---------------------------------------------------
 
    // Start is called before the first frame update
    void Start()
    {
        world_shengcheng(20, 20);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void world_shengcheng(int chang,int kuan)
    {
        Camera.main.transform.position = new Vector3(chang / 2, kuan / 2, Camera.main.transform.position.z);//设置摄像机位置
        for (int x = 0; x <= chang; x++)
        {
            for (int y = 0; y <= kuan; y++)
            {
                GameObject hj = new GameObject();//生成物体
                SpriteRenderer tu=hj.AddComponent<SpriteRenderer>();//给物体添加SpriteRenderer组件用来显示图片
                hj.transform.parent = transform;//将物体设为当前脚本挂载的对象的子级
                hj.transform.position = new Vector2(x, y);//设置物体位置
                hj.name = "vector" + x + "--" + y;//为物体命名
                hanjindaxiao[new Vector2(x, y)] = hj;//字典绑定物体
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
  
}
