using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawners;
    private Vector2 limitis;

    void Start()
    {
        limitis = new Vector2(-2, 5);
        InvokeRepeating("Instantiate", 0, 4f);
    }

    private void Update()
    {
        if (FindObjectOfType<BirdController>().isDeath)
            Destroy(gameObject);
    }

    private void Instantiate()
    {
        BirdController bird = FindObjectOfType<BirdController>();

        if (bird.isDeath)
            return;

        int platformLength = 12;
        float positionX = bird.transform.position.x + platformLength;
        float positionY = Random.Range(limitis.x, limitis.y);

        int indexSpawner = Random.Range(0, spawners.Length);

        Instantiate(spawners[indexSpawner], new Vector2(positionX, positionY), Quaternion.identity);
    }
}
