using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBlock : MonoBehaviour
{
    [SerializeField]
    GameObject particles;

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    GameObject gunPaddle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            Instantiate(particles, gameObject.transform.position, Quaternion.identity);

            Camera.main.GetComponent<Spawner>().DestroyPaddle();
        }
    }

    //this.GetComponent<SpriteRenderer>().sprite = PlayerSideRight;
}
