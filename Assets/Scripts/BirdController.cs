using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdController : MonoBehaviour
{
    public bool isDeath { get; private set; }

    private float _velocityPerJump = 3;
    private float _speed = 2.4f;

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

    void Update()
    {
        if (isDeath)
            return;

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        MoveBirdOnXAxis();
        if (WasClicked || WasTouched)
            BoostOnYAxis();
    }

    public void ChangeBird(string name)
    {
        GameObject newBird = Resources.Load<GameObject>($"Prefabs/{name}");
        Instantiate(newBird, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    public void Death()
    {
        this.isDeath = true;

        FindObjectOfType<GameManager>().GameOver();
    }

    private void BoostOnYAxis()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, _velocityPerJump);
    }
}
