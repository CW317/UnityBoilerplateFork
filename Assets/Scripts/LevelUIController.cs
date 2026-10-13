using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUIController : MonoBehaviour
{
    public int Lives;
    public int score;
    public float TotalTime;
    public TextMeshProUGUI LivesLabel;
    public TextMeshProUGUI ScoreLabel;
    public TextMeshProUGUI TimeLabel;

    void Update()
    {
        TotalTime += Time.deltaTime;

        LivesLabel.text = "Lives: " + Lives;
        ScoreLabel.text = "Score: " + score;
        TimeLabel.text = "Time: " + TotalTime.ToString(format: "0.0") + "s";
    }
    public void Kill()
    {
        // kill the player once
        // if lives reaches 0, transition to a gave over screen
        Lives--;
        if(Lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Collect()
    {
        score++;
        if (score>=100)
        {
            Lives++;
            score -= 100;
        }
    }
}
