using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriger : MonoBehaviour
{
    // public GameManager gameManager;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
