using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI text;
    public GameObject gameOverPanel;

    public void Restart()
    {
        FindObjectOfType<GameManager>().Restart();
    }

    public void GameOver(SpriteRenderer spriteRenderer, int score)
    {
        gameOverPanel.SetActive(true);
        image.sprite = spriteRenderer.sprite;
        text.text = $"{score}";
        gameObject.SetActive(true);
    }
}
