using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// A ball
/// </summary>
public class Ball : MonoBehaviour
{
    [SerializeField]
    float ballImpusleSpeed = 500;

    [SerializeField]
    float delay;

    [SerializeField]
    float speedToIncrease;

    Rigidbody2D rb2d;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        StartCoroutine(Wait(delay));

        rb2d = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Sets the ball direction to the given direction
    /// </summary>
    /// <param name="direction">direction</param>
    public void SetDirection(Vector2 direction)
    {
        float speed = rb2d.velocity.magnitude;
        rb2d.velocity = direction * speed;
    }
    private void OnBecameInvisible()
    {
        float halfColliderHeight = gameObject.GetComponent<BoxCollider2D>().size.y / 2;
        if (transform.position.y - halfColliderHeight < ScreenUtils.ScreenBottom)
        {
            Camera.main.GetComponent<BallSpawner>().SpawnBall();
        }
        Destroy(gameObject);
    }
    public void ApplyForce()
    {
        // get the ball moving
        float angle = -90 * Mathf.Deg2Rad;
        Vector2 force = new Vector2(ballImpusleSpeed * Mathf.Cos(angle), ballImpusleSpeed *
            Mathf.Sin(angle));
        rb2d.AddForce(force);
    }
    public void IncreaseSpeed()
    {
        rb2d.AddForce(speedToIncrease * rb2d.velocity);
    }

    IEnumerator Wait(float delay)
    {
        yield return new WaitForSeconds(delay);
        ApplyForce();
    }
}
