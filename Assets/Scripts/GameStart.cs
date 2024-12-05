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
        player.transform.position = new Vector3(Random.Range(-7.0f, 7.0f), 1, Random.Range( 0.5f,  9.5f));
        ball.transform.position   = new Vector3(Random.Range(-7.0f, 7.0f), 1, Random.Range(-0.5f, -9.5f));

        Instantiate(ball);
        Instantiate(player);
    }
}
