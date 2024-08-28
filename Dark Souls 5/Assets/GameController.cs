using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public int totalScore;
    public Text scoreText;
    public GameObject gameOver;

    public static GameController instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }
    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

}
