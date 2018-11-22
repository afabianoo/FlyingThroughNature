using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class AleatoryBox : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer currentSprite;

    void Start()
    {
        currentSprite = GetComponent<SpriteRenderer>();
        InvokeRepeating("ChangeSprite", 0, 0.1f);
    }

    private void Update()
    {
        if (FindObjectOfType<BirdController>().isDeath)
            Destroy(gameObject);
    }

    void ChangeSprite()
    {
        int index = Random.Range(0, sprites.Length);
        currentSprite.sprite = sprites[index];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        Destroy(gameObject);
        string birdName = currentSprite.sprite.name.Replace("_3", "");
        collision.GetComponent<BirdController>().ChangeBird(birdName);
    }
}
