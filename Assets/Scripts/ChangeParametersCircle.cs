using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ChangeParametersCircle : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().color = Random.ColorHSV();
        float scale = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
