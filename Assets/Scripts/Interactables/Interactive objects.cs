using UnityEngine;
using UnityEngine.InputSystem;

namespace Interactables
{
    public abstract class Interactiveobjects : MonoBehaviour
    {
        [SerializeField] protected bool inTrigger;
        [SerializeField] protected string animKey;
    
        protected GameObject Player;
        protected CharacterControls CharacterControls;
        protected CharacterController CharacterController;
        protected Animator Animator;
        protected Controls Controls;
        protected Timer Timer;
        protected Score Score;

        protected virtual void Awake()
        {
            Animator = GetComponentInChildren<Animator>();
            Controls = new Controls();
            Controls.PlayerInGame.Interaction.performed += Activation;
            Timer = GameObject.FindWithTag("Timer").GetComponent<Timer>();
            Score = GameObject.FindWithTag("ScoreManager").GetComponent<Score>();
        }
    
        protected virtual void Update()
        {
            if (!Player) return;
            if (inTrigger) Controls.Enable();
            else Controls.Disable();
        }

        //With onTriggerEnter and onTriggerExit and bool inTrigger we emulate onTriggerStay in more consistent way
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (!other.GetComponent<CharacterControls>()) return;

            Player = other.gameObject;
            InitializePlayerComponents();

            inTrigger = true;
        
        }
        protected virtual void OnTriggerExit(Collider other)
        {
            inTrigger = false;
        
        }
        //Method to control Character controller in case we want to disable ability to control character in certain interactions
        protected void EnablePlayerControls()
        {
            CharacterControls.enabled = true;
            CharacterController.enabled = true;
        }

        protected void DisablePlayerControls()
        {
            CharacterControls.enabled = false;
            CharacterController.enabled = false;
        }
        private void InitializePlayerComponents()
        {
            CharacterControls = Player.GetComponent<CharacterControls>();
            CharacterController = Player.GetComponent<CharacterController>();
        
        }
        //
        protected virtual void Activation(InputAction.CallbackContext ctx)
        {
           if(animKey != null) Animator.Play(animKey, 0, 0f);
        }
    }
}

