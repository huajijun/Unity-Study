
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static int currentScore;
    void Start()
    {
        currentScore = PlayerPrefs.GetInt("Score", 0);
    }
    // Update is called once per frame
    void Update()
    {
        GameObject playTest = GameObject.Find("Player");
        Text scoreText = GetComponent<Text>();
        //scoreText.text = playTest..GetComponent<SomeComponent>().position.z.ToString("0");
        // scoreText.text = player.position.z.ToString("0");

        scoreText.text = (playTest.transform.position.z + currentScore).ToString("0");
        PlayerPrefs.SetInt("Score", int.Parse(scoreText.text));
        PlayerPrefs.Save();
    }

    public void SaveScoreBeforeSceneChange()
    {
        Text scoreText = GetComponent<Text>();
        PlayerPrefs.SetInt("Score", int.Parse(scoreText.text));
        PlayerPrefs.Save();
    }
}
