using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    [SerializeField]
    private float xPos;

    [SerializeField]
    private float yPos;

    private float _timeUntilSpawn;

    private Vector2 spawnPosition;

    private int randomNumber;

    public GameObject player;

    void Awake()
    {
        SetTimeUntilSpawn();
        
    }

    void Update()
    {
        {
            _timeUntilSpawn -= Time.deltaTime;

            if (_timeUntilSpawn <= 0)
            {
                RandomPosition();
                Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
                SetTimeUntilSpawn();
            }
        }
    }

    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }

    private void RandomPosition()
    {
        randomNumber = Random.Range(0,4);
        if (randomNumber == 0)
        {
            spawnPosition = new Vector2 (xPos,Random.Range(-yPos,yPos));
        }
        if (randomNumber == 1)
        {
            spawnPosition = new Vector2 (-xPos,Random.Range(-yPos,yPos));
        }
        if (randomNumber == 2)
        {
            spawnPosition = new Vector2 (Random.Range(-xPos,xPos),yPos);
        }
        if (randomNumber == 3)
        {
            spawnPosition = new Vector2 (Random.Range(-xPos,xPos),-yPos);
        }
    }
    
}
