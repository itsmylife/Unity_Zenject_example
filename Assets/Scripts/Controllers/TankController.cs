using UnityEngine;
using System.Collections;
using Zenject;
using System;

public class TankController : ITankController
{
    Tank _tank;
    IMissileController _missileController;

    public TankController(Tank tank, IMissileController missileController)
    {
        _tank = tank;
        _missileController = missileController;
    }

    public void Setup()
    {
        _tank.Scale = new Vector3(2f, 2f, 2f);
    }

    public bool AnimateTankStep()
    {
        if(_tank.Scale == new Vector3(0.1f, 0.1f, 0.1f))
        {
            return true;
        }
        else
        {
            _tank.Scale -= new Vector3(0.1f, 0.1f, 0.1f);
            return false;
        }
    }

    public void CaptureInput()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _tank.Rotation = Quaternion.Euler(0f, 0f, 180f);
            _tank.Position += Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _tank.Rotation = Quaternion.Euler(0f, 0f, 0f);
            _tank.Position += Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _tank.Rotation = Quaternion.Euler(0f, 0f, 90f);
            _tank.Position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _tank.Rotation = Quaternion.Euler(0f, 0f, -90f);
            _tank.Position += Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _missileController.CreateMissile(_tank.Position, _tank.Rotation);
        }
    }

}
