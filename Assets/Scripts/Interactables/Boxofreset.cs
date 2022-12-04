using Interactables;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Boxofreset : Interactiveobjects
{
    [SerializeField] private float _rotationSpeed;
    protected override void Activation(InputAction.CallbackContext ctx)
    {
        Score.ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    protected override void Update()
    {
        base.Update();
        transform.Rotate (0,_rotationSpeed, 0 );
    }
}
