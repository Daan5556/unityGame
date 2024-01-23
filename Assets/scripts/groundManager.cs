using Unity.VisualScripting;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (allEnemiesKilled())
        {
            spawnGround();
        }
        allEnemiesKilled();
    }
    private void spawnGround()
    {
        GameObject newGround = Instantiate(groundPrefab, new Vector3(lastSpawnX + spawnDistance, -7.45F, 0f), Quaternion.identity);
        lastSpawnX = newGround.transform.position.x;
    }
    private bool allEnemiesKilled()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemies)
        {
            Rigidbody2D enemyRigidbody = enemy.GetComponent<Rigidbody2D>();

            if (enemyRigidbody != null && !enemyRigidbody.isKinematic)
            {
                return false;
            }
        }
        return true;
    }
}
