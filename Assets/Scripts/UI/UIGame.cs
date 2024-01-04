using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIGame : MonoBehaviour
{
    [SerializeField] private Button _RestartButton;
    [SerializeField] private Button _MenuButton;
    
    void Start()
    {
        _MenuButton.onClick.AddListener(LoadMenuScene);
        _RestartButton.onClick.AddListener(ReloadGameScene);
    }

    private void LoadMenuScene()
    {
        ScenesManager.Instance.LoadMenu();
    }
    private void ReloadGameScene()
    {
        ScenesManager.Instance.LoadNewGame();
    }

}
