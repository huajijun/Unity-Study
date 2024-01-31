
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
 
    void OnCollisionEnter(Collision Info )
    {

        if (Info.collider.tag == "obstacle") {
            GetComponent<Player>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
