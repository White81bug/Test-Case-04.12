using UnityEngine;
using UnityEngine.InputSystem;

namespace Interactables
{
    public class Door : Interactiveobjects
    {
        [SerializeField] private bool isOpen;
        [SerializeField] private string closeAnim;
        [SerializeField] private bool isTimerLocked;

        protected override void Activation(InputAction.CallbackContext ctx)
        {
            if(isTimerLocked && Timer.CurrentTimerState == Timer.TimerState.Stopped) return;
            //Open door if it is closed
            if (!isOpen)
            {
                base.Activation(ctx);
                isOpen = true;
            }
            //Close the door if it is opened
            else
            {
                Animator.Play(closeAnim, 0, 0f);
                isOpen = false;
            }
        }


    }
}
