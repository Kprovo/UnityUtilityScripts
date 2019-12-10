using UnityEngine;
using UnityEngine.Networking;

// Attatch this class to a GameObject you want to spawn on the server
public class NetworkSpawn : NetworkBehaviour
{
    public GameObject myGameObject;
    GameObject myInstantiated;

    void Start()
    {
        myInstantiated = Instantiate(myGameObject);
        // Spawn the GameObject on the server
        NetworkServer.Spawn(myInstantiated);
    }
}