using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Interactables
{
   public class Chest : Interactiveobjects
   {
      [SerializeField] private bool isOpen;
      [SerializeField] private string closeAnim;
      [Header("How much loot worth")]
      [SerializeField] private int lootWorth;
      [Header("How ling it it takes to loot chest")]
      [SerializeField] private float lootingTime;
      [SerializeField] private bool isLooted;
     

      protected override void Awake()
      {
          base.Awake();
          Score = GameObject.FindWithTag("ScoreManager").GetComponent<Score>();
      }

      protected override void Activation(InputAction.CallbackContext ctx)
      {
         
          // Loot Chest
          if (!isLooted & isOpen)
          {
              StartCoroutine(Looting());
          }
          //Open Closed chest.
          if (!isOpen)
          {
              base.Activation(ctx);
              isOpen = true;
          }
          //Close Looted Chest
          else if(isOpen & isLooted)
          {
              Animator.Play(closeAnim, 0, 0f);
              isOpen = false;
          }
          
      }

      private IEnumerator Looting()
      {
          DisablePlayerControls();
          yield return new WaitForSeconds(lootingTime);
          EnablePlayerControls();
          isLooted = true;
          Score.AddScore(lootWorth);
      }
   }
   
}
