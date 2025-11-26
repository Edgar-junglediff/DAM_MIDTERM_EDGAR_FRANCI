using UnityEngine;

public class BALLMANAGER : MonoBehaviour
{

    public float ballSpeed = 5.0f;
    public Rigidbody2D body2D;
    
    public GameObject palla;
    public Vector2 nuovaVelocità;

    public void Awake()
    {
        move();
    }

    public void ResetPosition()
    {
        transform.position = new Vector3(0, 0, 0);
        move();
    }

    public void move()
    {
        float[] xDirection = { ballSpeed, -ballSpeed };
        float[] yDirection = { ballSpeed, -ballSpeed };
        body2D.linearVelocity = new Vector2(xDirection[Random.Range(0,2)],yDirection[Random.Range(0,2)]);
    }

}
