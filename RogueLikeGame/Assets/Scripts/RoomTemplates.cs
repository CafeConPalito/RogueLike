using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{

    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    //Tiempo que espera para que al terminar de montar las salas Spawnee el Boss.
    public float waitTimeBossSpawn;
    private bool spawnedBoss;
    public GameObject boss;

    void Update()
    {
        
        if (waitTimeBossSpawn <= 0 && spawnedBoss == false)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == rooms.Count - 1)
                {
                    Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                    spawnedBoss = true;
                }
            }
        }
        else
        {
            waitTimeBossSpawn -= Time.deltaTime;
        }
        
    }


}
