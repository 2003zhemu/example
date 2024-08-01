using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class more : MonoBehaviour
{
    public float speed;
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yidon();
    }
    private void yidon()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.position += transform.up * y * speed * Time.deltaTime;
        transform.Rotate(0, 0, -1*rotation * x * Time.deltaTime);
    }
}
