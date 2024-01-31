using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadScene()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ResetScore();
   }

   public void ResetScore()
   {
     PlayerPrefs.SetInt("Score", 0);
     PlayerPrefs.Save(); // 确保保存更改
   }
}
