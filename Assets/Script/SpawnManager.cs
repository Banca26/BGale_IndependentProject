using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject doorPrefab;
    private Vector3 spawnPos = new Vector3(5, 0, 0);
    private PlayerController playerCtrl;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDoor", 5, 2);
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
   

    void SpawnDoor()
    {
        if (playerCtrl.gameOver == false)
        Instantiate(doorPrefab, spawnPos, doorPrefab.transform.rotation); 
    }
}
