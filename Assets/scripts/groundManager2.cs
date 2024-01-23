using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundManager2 : MonoBehaviour
{
    public GameObject groundPrefab;
    [SerializeField] int islandsSpawned;
    [SerializeField] float offset;
    private int objectSpawned;
    private float lastSpawnX;

    
    // Start is called before the first frame update
    void Start()
    {
        islandsSpawned = 1;
    }

    // Update is called once per frame
    void Update()
    {
        while (objectSpawned < islandsSpawned) {
            spawnGround();
        }
        
    }

    private void spawnGround()
    {
        GameObject newGround = Instantiate(groundPrefab, new Vector3(lastSpawnX + offset, -7.45F, 0f), Quaternion.identity);
        lastSpawnX = newGround.transform.position.x;
        objectSpawned++;
    }
}
