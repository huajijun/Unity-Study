using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 鼠标的点击  0 左键 1 右键 2 滚轮
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("left");
        }
        //持续按下鼠标
        if(Input.GetMouseButton(0))
        {
            Debug.Log("continue");
        }
        //抬起鼠标
        if(Input.GetMouseButtonUp(0)){

        }

        // 键盘 和上面一样
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("c a");
        }
        if(Input.GetKeyUp("a")){
            Debug.Log("d a");
        }
    }
}
