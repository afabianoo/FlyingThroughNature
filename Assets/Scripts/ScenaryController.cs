using UnityEngine;

public class ScenaryController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] backgrounds;

    private float groundHorizontalLength = 20.45f;
    private int currentIndex;

    void Update()
    {
        BirdController bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdController>();

        if (bird.isDeath)
            return;

        Vector2 birdPosition = bird.transform.position;
        Vector2 currentPosition = backgrounds[currentIndex].transform.position;

        float length = currentPosition.x + groundHorizontalLength;

        if (birdPosition.x >= length)
            ChangeGroundPosition(length);
    }

    private void ChangeGroundPosition(float length)
    {
        backgrounds[currentIndex].transform.position = new Vector2(length + groundHorizontalLength, 0);
        currentIndex = currentIndex == 0 ? 1 : 0;
    }
}
