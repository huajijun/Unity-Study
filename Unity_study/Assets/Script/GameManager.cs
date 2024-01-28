
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnd = false;
    public float restartDelay = 1f;
    // Start is called before the first frame update

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnd == false)
        {
            gameHasEnd = true;
            Debug.Log("End Game");
            Invoke("Restart",restartDelay);
            // Restart();
        }
        
    }

    void Restart()
    {
        // SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
