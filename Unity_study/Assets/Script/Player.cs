using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello world");
        // rb.useGravity = false;
        //在每个方向上 施加多少力
        // rb.AddForce(0, 0,500);
        // FindObjectOfType<AudioManager>().PlayMusic(yourMusicClip);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     rb.AddForce(0, 0, 300 * Time.deltaTime);
    // }
    // 固定更新

    //翻滚的原因是摩擦力
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce*Time.deltaTime,ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce*Time.deltaTime,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }


}
