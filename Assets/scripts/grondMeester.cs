using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grondMeester : MonoBehaviour
{
    public GameObject groundPrefab;
    [SerializeField] int islandsSpawned;
    [SerializeField] float offset;
    [SerializeField] Rigidbody2D EnemyRB;
    private int objectSpawned;
    private float lastSpawnX;
    private float enemyRigidBoyd;

    // Start is called before the first frame update
    void Start()
    {
        islandsSpawned = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (islandsSpawned > 1)
        {
            offset = 40;
        }
        while (objectSpawned < islandsSpawned)
        {
            spawnGround();
        }
        allEnemiesKilled();


    }

    private void spawnGround()
    {
        GameObject newGround = Instantiate(groundPrefab, new Vector3(lastSpawnX + offset, -7.45F, 0f), Quaternion.identity);
        lastSpawnX = newGround.transform.position.x;
        objectSpawned++;
    }

    private bool allEnemiesKilled()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemies)
        {
        Rigidbody2D enemyRigidbody = enemy.GetComponent<Rigidbody2D>();
            if (!enemyRigidbody.isKinematic)
            {
                return false;
            }
        }
        islandsSpawned += 1;
            return true;
    }
}
