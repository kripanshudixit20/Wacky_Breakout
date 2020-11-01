using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBall;

    private void Awake()
    {
        SpawnBall();
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
