using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private void LateUpdate()
    {
        Vector2 birdPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        var s = new Vector3(birdPosition.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, s, 2.4f * Time.deltaTime);
    }
}
