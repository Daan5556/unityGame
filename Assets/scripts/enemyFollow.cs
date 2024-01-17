using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {

        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        if (player == null)
        {
            // If the player is not set, try to find it in the scene
            player = GameObject.FindGameObjectWithTag("Player").transform;

            if (player == null)
            {
                Debug.LogError("Player not found. Make sure the player has the tag 'Player'.");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        {
            // Set the destination to the player's position
            navMeshAgent.SetDestination(player.position);
        }

    }
}
