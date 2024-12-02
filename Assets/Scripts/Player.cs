using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject ball;
    GameObject goal;

    Vector3 vector;
    Vector3 playerGoal;

    public bool atGoal = false;
    public bool kicked = false;

    float waitTimeForKick = 1.0f;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        goal = GameObject.FindGameObjectWithTag("Goal");

        vector = ball.transform.position - goal.transform.position;
        playerGoal = ball.transform.position + (vector / 3);
    }

    void Update()
    {
        if(!atGoal) transform.position += (playerGoal - transform.position).normalized * 5 * Time.deltaTime;

        if(Round(transform.position.x) == Round(playerGoal.x) && Round(transform.position.z) == Round(playerGoal.z)) atGoal = true;

        if(atGoal && !kicked)
        {
            StartCoroutine(Kick());
        }
    }

    IEnumerator Kick()
    {
        vector = goal.transform.position - ball.transform.position;
        yield return new WaitForSeconds(waitTimeForKick);
        kicked = true;

        ball.GetComponent<Rigidbody>().velocity = vector.normalized * 10;
    }

    float Round(float x)
    {
        return Mathf.Round(x * 100f) * 0.01f;
    }
}