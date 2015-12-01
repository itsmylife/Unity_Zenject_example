using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ITankController
{
    void Setup();
    bool AnimateTankStep();
    void CaptureInput();
}
