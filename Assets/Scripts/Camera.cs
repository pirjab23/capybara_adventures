using UnityEngine;
using UnityEngine.UIElements;

public class Camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool nextCam = false;
        if (nextCam)
        {
            transform.position = new Vector2(0, 16);
        }
    }
}
