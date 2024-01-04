using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject CirclePref;

    private float maxSpawnT = 0.05f;
    private float minSpawnT = 0.6f;
    
    private float delay = 0;
    private float visibleHeight;
    private float visibleWidth;
    private Rect spawnRegion;
    public GameObject circles;
    private void Awake()
    {
        //calculate the size of spawning field
        Camera camera = Camera.main;
        Vector3 bottomLeft = camera.ScreenToWorldPoint(new Vector3(135, 100, camera.nearClipPlane));
        Vector3 topRight = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth-135, camera.pixelHeight-100, camera.nearClipPlane));
        spawnRegion = new Rect(bottomLeft.x, bottomLeft.y, topRight.x - bottomLeft.x, topRight.y - bottomLeft.y);
        circles = GameObject.Find("Circles");
    }
    void Update()
    {
        if (delay <= 0)
        {
            SpawnCircle();
            delay = Random.Range(minSpawnT, maxSpawnT);
        }
        else
        {
            delay -= 1 * Time.deltaTime;
        }
    }

    private void SpawnCircle()
    {
        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnRegion.xMin, spawnRegion.xMax),
            Random.Range(spawnRegion.yMin, spawnRegion.yMax)
        );
        GameObject temp = Instantiate( CirclePref, spawnPosition, Quaternion.identity);
        temp.transform.parent = circles.transform;
    }
}
