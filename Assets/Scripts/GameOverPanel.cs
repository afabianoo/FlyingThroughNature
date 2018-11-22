using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI text;

    private void OnEnable()
    {
        image.sprite = FindObjectOfType<BirdController>().GetComponent<SpriteRenderer>().sprite;
        text.text = $"{FindObjectOfType<Timer>().Score}";
    }
}
