using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private int playerFormIndex = 0;
    public Action<int> indexChange;
    public Action<bool> isAttacking;
    public void changeChara(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            playerFormIndex = playerFormIndex > 2 ? 0 : playerFormIndex + 1;
            indexChange?.Invoke(playerFormIndex);
            isAttacking?.Invoke(false);
        }
    }

    public void attackInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isAttacking?.Invoke(true);
        }
        if (context.canceled)
        {
            isAttacking?.Invoke(false);
        }
    }
}
