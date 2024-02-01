using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriger : MonoBehaviour
{
    // public GameManager gameManager;
    // Start is called before the first frame update
    public GameObject effect;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            Invoke("delay",1);
            PickUp(other);
        }
        
    }
    void delay()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
    void PickUp(Collider other)
    {
        Instantiate(effect, other.transform.position,other.transform.rotation);
    }
}
