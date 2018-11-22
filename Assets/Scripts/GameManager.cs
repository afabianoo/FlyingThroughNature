using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
    public void GameOver()
    {
        SpriteRenderer birdSprite = FindObjectOfType<BirdController>().GetComponent<SpriteRenderer>();
        int score = FindObjectOfType<Timer>().Score;
        FindObjectOfType<Menu>().GameOver(birdSprite, score);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
