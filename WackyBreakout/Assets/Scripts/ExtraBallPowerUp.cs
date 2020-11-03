using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBallPowerUp : MonoBehaviour
{
    [SerializeField]
    GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Destroys the block on collision with a ball and generates a power up
    /// </summary>
    /// <param name="coll">Coll.</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            Instantiate(particles, gameObject.transform.position, Quaternion.identity);

            Camera.main.GetComponent<Spawner>().SpawnBall();
        }
    }
}
