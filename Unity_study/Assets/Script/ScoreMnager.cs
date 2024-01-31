using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMnager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int currentScore;
    public static int highScore;
    void Start()
    {
        Text text = GameObject.Find("Score").GetComponent<Text>();
        currentScore = PlayerPrefs.GetInt("Score", 0);
        text.text = PlayerPrefs.GetInt("Score", 0).ToString();
        Text htext = GameObject.Find("HighScore").GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log(currentScore >= highScore);
        if (currentScore >= highScore){
            PlayerPrefs.SetInt("HighScore", currentScore);
            PlayerPrefs.Save();
            htext.text = currentScore.ToString();
        }
        else {
            htext.text = highScore.ToString();
        }
        

        

    }

    // Update is called once per frame
    public void ResetHightScore()
    {
        
        PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.Save();
        Text htext = GameObject.Find("HighScore").GetComponent<Text>();
        htext.text = 0.ToString();
    }
}
