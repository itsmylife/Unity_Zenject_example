using System;
using UnityEngine;
using Zenject;

public class GameView : ITickable, IInitializable
{
    ITankController _tankController;
    bool _isTankReady;

    public GameView(ITankController tankController)
    {
        _tankController = tankController;
    }

    public void Initialize()
    {
        _tankController.Setup();
    }

    public void Tick()
    {
        if(_isTankReady)
        {
            _tankController.CaptureInput();
        }

        _isTankReady = _tankController.AnimateTankStep();
    }
}
