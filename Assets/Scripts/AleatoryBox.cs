using System.Collections.Generic;
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
        BirdController bird = FindObjectOfType<BirdController>();
        if (bird.isDeath)
            return;

        List<Sprite> spritesAvailable = new List<Sprite>();

        foreach (var sprite in sprites)
        {
            if (FormatName(sprite.name) == FormatName(bird.GetComponent<SpriteRenderer>().sprite.name))
                continue;

            spritesAvailable.Add(sprite);
        }

        currentSprite.sprite = spritesAvailable[Random.Range(0, spritesAvailable.Count)];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        Destroy(gameObject);
        string birdName = FormatName(currentSprite.sprite.name);
        collision.GetComponent<BirdController>().ChangeBird(birdName);
    }

    private string FormatName(string spriteName)
    {
        string[] parts = spriteName.Split('_');
        return parts[0] + "_" + parts[1];
    }
}
