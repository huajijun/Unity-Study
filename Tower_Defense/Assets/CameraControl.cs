
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float panSpeed = 30f;
    public float scrollSpeed = 5f;
    public float pad = 10f;

    public bool doMove = true;

    public float minY = 10f;
    public float maxY = 80f;



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            doMove = !doMove;
        }
        if (!doMove)
        {
            return ;
        }
        if(Input.GetKey("w") ||  Input.mousePosition.y >=  Screen.height - pad)
        {
            transform.Translate(Vector3.forward * panSpeed*Time.deltaTime, Space.World);
        }
        else if(Input.GetKey("s") ||  Input.mousePosition.y <= pad)
        {
            transform.Translate(Vector3.back * panSpeed*Time.deltaTime, Space.World);
        }
        else if(Input.GetKey("a") ||  Input.mousePosition.x <= pad)
        {
            transform.Translate(Vector3.left * panSpeed*Time.deltaTime, Space.World);
        }
        else if(Input.GetKey("d") || Input.mousePosition.x >=  Screen.width - pad)
        {
            transform.Translate(Vector3.right * panSpeed*Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;
        pos.y -= scroll * scrollSpeed * Time.deltaTime * 1000;
        pos.y = Mathf.Clamp(pos.y,minY,maxY);
        transform.position = pos;
    }


    


}
