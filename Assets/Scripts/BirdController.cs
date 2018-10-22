using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdController : MonoBehaviour
{
    private float _velocityPerJump = 3;
    private float _speed = 2.4f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        MoveBirdOnXAxis();
        if (WasClicked || WasTouched)
            BoostOnYAxis();
    }

    private bool WasClicked
    {
        get { return Input.GetButtonUp("Jump"); }
    }

    private bool WasTouched
    {
        get { return Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended); }
    }

    private void MoveBirdOnXAxis()
    {
        transform.position += new Vector3(Time.deltaTime * _speed, 0, 0);
    }

    private void BoostOnYAxis()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, _velocityPerJump);
    }
}
