using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    public GameOverPanel gameOverPanel;
    public GamePanel gamePanel;

    public void Restart()
    {
        FindObjectOfType<GameManager>().Restart();
    }

    public void GameOver()
    {
        gamePanel.gameObject.SetActive(false);
        gameOverPanel.gameObject.SetActive(true);
    }
}
