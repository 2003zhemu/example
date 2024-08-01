using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 chushiweizhi;
    private Vector3 mouweizhi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseweiyi();
    }
    private void mouseweiyi()
    {
        mouweizhi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(2))
        {
            Vector3 pos = chushiweizhi - mouweizhi;
            Camera.main.transform.Translate(pos);
        }
        Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * Camera.main.orthographicSize;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, 3, 50);
        chushiweizhi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
