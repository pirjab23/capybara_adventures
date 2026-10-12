using UnityEngine;

public class Mario : MonoBehaviour
{

    public float moveSpeed = 5;
    bool lookRight = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MarioScript");
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (yInput < 0)
        {
            return;
        }
        float xDistance = moveSpeed * xInput * Time.deltaTime;
        float yDistance = moveSpeed * yInput * Time.deltaTime;
        
        transform.position = (Vector2)transform.position + new Vector2(xDistance, yDistance);
        // oder               = transform.position + new Vector3(xDistance, yDistance, 0) => 0 brauchen wir nicht, dafür typecast

        if (lookRight && xInput < 0 || !lookRight && xInput > 0)
        {
            lookRight = !lookRight;
            transform.Rotate(0, 180, 0);
        }
    }
}
