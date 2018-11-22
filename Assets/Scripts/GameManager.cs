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
        FindObjectOfType<MenuPanel>().GameOver();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
