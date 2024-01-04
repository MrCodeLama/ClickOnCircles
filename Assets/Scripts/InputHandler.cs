using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputHandler : MonoBehaviour
{
    [SerializeField] private ScoreManager ScoreManager;
    [SerializeField] private SoundManager SoundManager;
    private Camera _mainCamera;
    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void onClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(
            _mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        
        if(!rayHit.collider) return;
        
        if (rayHit.collider.gameObject.tag == "Circle")
        {
            ScoreManager.IncrementScore();
            
            Destroy(rayHit.collider.gameObject);
            SoundManager.playCircle();
        }
    }
}