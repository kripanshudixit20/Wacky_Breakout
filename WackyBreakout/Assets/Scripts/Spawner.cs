using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBall;

    [SerializeField]
    GameObject normalPaddle;

    private void Awake()
    {
        SpawnBall();
        Instantiate(normalPaddle, new Vector2(0f, -4.5f), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnBall()
    {
        Instantiate(prefabBall, new Vector2(0, 0), Quaternion.identity);
    }
}
