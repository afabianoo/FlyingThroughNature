using UnityEngine;

public class Ground : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        collision.GetComponent<BirdController>().Death();
    }
}
