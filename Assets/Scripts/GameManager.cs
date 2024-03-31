using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject ball;

    public TextMeshProUGUI enemyPointer;
    public TextMeshProUGUI playerPointer;

    public TextMeshProUGUI winText;
    public TextMeshProUGUI textEndGame;

    public int playerCount = 0;
    public int enemyCount = 0;


    public Ball ballScript;
    private void Start()
    {
        ResetGame();
    }

    private void ResetGame()
    {
        Invoke("BallVelocity", 1f);
        playerCount = 0;
        enemyCount = 0;
        winText.SetText("");
        player.SetActive(true);
        enemy.SetActive(true);
        ball.SetActive(true);
        enemyPointer.SetText("0");
        playerPointer.SetText("0");
        enemy.transform.position = new Vector2(-17, 0);
        player.transform.position = new Vector2(17, 0);
        ball.transform.position = Vector3.zero;
    }
    public void BallVelocity()
    {
        ballScript.rb.velocity = ballScript.startVelocity;

    }

    void gameOver() 
    {
        player.SetActive(false);
        enemy.SetActive(false);
        ball.SetActive(false);
        
    }
    private void Update()
    {
        EndGame();
    }
    public void EndGame()
    {
        string winner = SaveControler.Instance.GetName(playerCount > enemyCount);
        SaveControler.Instance.SaveWinner(winner);
        if ((playerCount == 5) || (enemyCount == 5))
        {
            winText.SetText("Vitória do" + " " + winner);
            gameOver();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
            //ResetGame();
        }

    }
    public void ResetBall()
    {
        enemy.transform.position = new Vector2(-17, 0);
        player.transform.position = new Vector2(17, 0);
        ball.transform.position = Vector3.zero;
    }

    public void SetPlayerPoint(int b)
    {
        playerCount += b;
        playerPointer.SetText(playerCount.ToString());
    }
    public void SetEnemyPoint(int b)
    {
        enemyCount += b;
        enemyPointer.SetText(enemyCount.ToString());
        
    }

}
