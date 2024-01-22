using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundManager : MonoBehaviour
{
    public GameObject groundPrefab;
    public float spawnDistance = 10f;
    public float playerOffset = 5f;

    private Transform playerTransform;
    private float lastSpawnX;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        spawnGround();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x - lastSpawnX > spawnDistance)
        {
            spawnGround();
        }
        allEnemiesKilled();
    }
    private void spawnGround()
    {
        GameObject newGround = Instantiate(groundPrefab, new Vector3(playerTransform.position.x + playerOffset, -7.45F, 0f), Quaternion.identity);

        playerOffset += spawnDistance;

        lastSpawnX = playerTransform.position.x;
    }
    private bool allEnemiesKilled()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemies)
        {

            if (enemy.activeSelf)
            {
                return false;
            }
        }
        return true;
    }

}
