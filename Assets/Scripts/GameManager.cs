using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int enemiesRemaining; 

    void Start()
    {
        
        enemiesRemaining = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

   
    public void EnemyDestroyed()
    {
        enemiesRemaining--;

        
        if (enemiesRemaining <= 0)
        {
            LoadVictoryScene();
        }
    }

  
    void LoadVictoryScene()
    {
        SceneManager.LoadScene("VictoryScene"); 
    }
}
