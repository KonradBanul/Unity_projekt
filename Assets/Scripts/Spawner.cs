using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public GameObject[] meteors;
    public float startTime;
    public float decrease;
    private float timeSpawn;
    public float mini = 0.5f;
    public int score = 0;
    public TMP_Text scoreText;

    private void Update() {
        if (timeSpawn <= 0) {
            int rand = Random.Range(0, meteors.Length);
            Instantiate(meteors[rand], transform.position, Quaternion.identity);
            timeSpawn = startTime;
            if ((startTime - decrease) >= mini) {
                startTime -= decrease; 
            }
            score += 4;
            scoreText.SetText(score.ToString());
        }
        else {
            timeSpawn -= Time.deltaTime;
        }
    }
}
