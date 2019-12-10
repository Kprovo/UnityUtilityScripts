using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnHandler : MonoBehaviour
{
    public Vector3 spawnPoint;
    public GameObject player;

    void Respawn()
    {
        // Set player position to spawnpoint
        player.transform.position = spawnPoint;
    }
}