using TMPro;
using UnityEngine;

public class GamePanel : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = $"{FindObjectOfType<Timer>().Score}";
    }
}
