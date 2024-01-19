using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //获取位置  
        // Debug.Log(transform.position);
        // Debug.Log(transform.localPosition);
        // Debug.Log(transform.rotation);
        // Debug.Log(transform.eulerAngles);
        // Debug.Log(transform.localEulerAngles);
        // Debug.Log(transform.localScale);

        // Debug.Log(transform.forward);
        // Debug.Log(transform.right);
        // Debug.Log(transform.up);

        

        // 父子关系
        Debug.Log(transform.parent.position);
        // 子物体个数
        Debug.Log(transform.childCount);
        // 解除与父物体的关系
        //transform.DetachChildren();
        // 获取子物体
        Transform trans = transform.Find("Capsule");
        trans = transform.GetChild(0);
        // 判断一个物体是不是另外一个物体的子物体
        bool res= trans.IsChildOf(transform);
        // 设置为父物体
        trans.SetParent(transform);
    }

    // Update is called once per frame
    void Update()
    {
        //时时刻刻 看向000点
        //transform.LookAt(Vector3.zero);
        //旋转
        //transform.Rotate(Vector3.up,1);
        // 绕某个物体旋转
        //transform.RotateAround(Vector3.zero, Vector3.forward, 5);
        // 移动
        //transform.Translate(Vector3.forward*0.11f);


    }
}
