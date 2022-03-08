using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHolder : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Text scoreText;

    Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;

        InvokeRepeating("SpawnEnemy", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        spawnPosition.y = 5;
    }

    public void SpawnEnemy()
    {
        scoreText.text = MamPlayer.score.ToString();

        spawnPosition.x = Random.Range(-7, 7);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
