using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject ball;

    void Start()
    {
        float randomX = Random.Range(-transform.localScale.x + 0.5f, transform.localScale.x - 0.5f);
        float randomZ = Random.Range(-transform.localScale.z + 0.5f, transform.localScale.z - 0.5f);

        Vector3 newPosition = new Vector3(randomX, player.transform.position.y, randomZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
