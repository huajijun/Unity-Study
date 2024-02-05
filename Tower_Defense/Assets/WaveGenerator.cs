using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ennemyPref;
    public Transform spawnPoint;

    public Text waveCountDownText;

    public float timeBetweenWaves = 3f;
    public float countDown = 2f;

    private int waveNumber = 0;




    void Update()
    {
        if (countDown < 0f) 
        {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }
        countDown -= Time.deltaTime;
        waveCountDownText.text = Mathf.Round(countDown).ToString();
    }

     IEnumerator SpawnWave()
     {

        waveNumber++;

        for (int i = 0 ; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
     }

     void SpawnEnemy()
     {
        Instantiate(ennemyPref, spawnPoint.position, spawnPoint.rotation);
     }

}
