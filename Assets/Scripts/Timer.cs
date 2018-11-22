using UnityEngine;

public class Timer : MonoBehaviour
{
    public int Score
    {
        get { return (int)Mathf.Abs(Time.deltaTime * 100); }
    }
}
