using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // public GameObject Player;
    // public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // 如果调用这个会和物体本身产生竞争
    // void Update()
    // {
    //     GameObject player = GameObject.Find("Player");
    //     transform.position = player.transform.position + offset;
    // }

    // 平滑过渡 很帅气
    void LateUpdate()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 desirePosion = player.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position,desirePosion,smoothSpeed);
        transform.position = smoothPosition;
        transform.LookAt(player.transform);
    }
}
