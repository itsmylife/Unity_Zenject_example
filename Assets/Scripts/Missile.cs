using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
        set
        {
            transform.position = value;
        }
    }

    public Quaternion Rotation
    {
        get
        {
            return transform.rotation;
        }
        set
        {
            transform.rotation = value;
        }
    }

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 startingPosition = Position;
        Vector3 goalPosition = Vector3.zero;
        
        //Down
        if (Rotation.eulerAngles == Quaternion.Euler(0f, 0f, 180f).eulerAngles)
        {
            goalPosition = new Vector3(startingPosition.x, -6f, startingPosition.z);
        }
        //Up
        else if (Rotation.eulerAngles == Quaternion.Euler(0f, 0f, 0f).eulerAngles)
        {
            goalPosition = new Vector3(startingPosition.x, 6f, startingPosition.z);
        }
        //Left
        else if(Rotation.eulerAngles == Quaternion.Euler(0f, 0f, 90f).eulerAngles)
        {
            goalPosition = new Vector3(-12f, startingPosition.y, startingPosition.z);
        }
        //Right
        else if (Rotation.eulerAngles == Quaternion.Euler(0f, 0f, 270f).eulerAngles)
        {
            goalPosition = new Vector3(12f, startingPosition.y, startingPosition.z);
        }

        Debug.DrawLine(startingPosition, goalPosition);

        Position = Vector3.MoveTowards(startingPosition, goalPosition, 0.1f);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
    }
}
