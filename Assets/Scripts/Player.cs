using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    GameObject ball;
    GameObject goal;

    Vector3 vector;
    Vector3 playerGoal;

    public bool atGoal = false;
    public bool kicked = false;
    public bool restart = false;

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
        DoGOAP();

        if (ball.transform.position.z <= -11) StartCoroutine(Restart());
    }

    void DoGOAP()
    {
        if (!atGoal) MoveTowardBall();
        if (atGoal && !kicked) StartCoroutine(KickBall());
    }

    void MoveTowardBall()
    {
        transform.position += (playerGoal - transform.position).normalized * 5 * Time.deltaTime;

        if (Round(transform.position.x) == Round(playerGoal.x) && Round(transform.position.z) == Round(playerGoal.z))
            atGoal = true;
    }

    IEnumerator KickBall()
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

    IEnumerator Restart()
    {
        restart = true;
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("MainScene");
    }
}