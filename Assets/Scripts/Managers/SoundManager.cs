using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource src;
    public AudioClip circle;
    public AudioClip gameover;
    public void playCircle()
    {
        src.clip = circle;
        src.Play();
    }
    public void playGameOver()
    {
        src.clip = gameover;
        src.Play();
    }
}
