using System;
using UnityEngine;
using Zenject;

public class MissileController : IMissileController
{
    GameObjectFactory<Missile> _missileFactory;

    public MissileController(GameObjectFactory<Missile> missileFactory)
    {
        _missileFactory = missileFactory;
    }

    public void CreateMissile(Vector3 position, Quaternion rotation)
    {
        var firedMissile = _missileFactory.Create();
        firedMissile.Position = position;
        firedMissile.Rotation = rotation;
    }
}
