using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; 
    private int score = 0; 

    void Start()
    {
        UpdateScoreUI(); 
    }

    
    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd; 
        UpdateScoreUI(); 
    }

   
    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString(); 
    }
}
