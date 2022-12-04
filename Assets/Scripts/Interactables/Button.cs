using UnityEngine;
using UnityEngine.InputSystem;

namespace Interactables
{
    public class Button : Interactiveobjects
    {
        private bool _activated;

        protected override void Activation(InputAction.CallbackContext ctx)
        {
            if(_activated) return;
            _activated = true;
            base.Activation(ctx);
            switch (Timer.CurrentTimerState == Timer.TimerState.Stopped)
            {
                case true:
                    Timer.StartTimer();
                    break;
                case false: Timer.StopTimer();
                    Score.AddScore(-(int)Timer.time);
                    break;
            }
       
            
        }
    }
}
