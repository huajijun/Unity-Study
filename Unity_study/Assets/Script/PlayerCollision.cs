
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player player;
    public GameManager gameManager;    
    void OnCollisionEnter(Collision Info )
    {
        Debug.Log(Info.collider.name);
        Debug.Log(Info.collider.tag);
        if (Info.collider.tag == "obstacle") {
            GetComponent<Player>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
