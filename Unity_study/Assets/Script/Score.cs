
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        GameObject playTest = GameObject.Find("Player");
        Text scoreText = GetComponent<Text>();
        //scoreText.text = playTest..GetComponent<SomeComponent>().position.z.ToString("0");
        // scoreText.text = player.position.z.ToString("0");
        scoreText.text = playTest.transform.position.z.ToString("0");
    }
}
