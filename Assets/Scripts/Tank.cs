using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour
{
    public SpriteRenderer TankSprite;

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

    public Vector3 Scale
    {
        get
        {
            return transform.localScale;
        }
        set
        {
            transform.localScale = value;
        }
    }

    public Color Color
    {
        get
        {
            return TankSprite.color;
        }
        set
        {
            TankSprite.color = value;
        }
    }


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
