using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy_Follow_Simple : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    private Vector2 movement;

    void Start()
	{
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

	private void FixedUpdate()
	{
        MoveForward(movement);
	}

	void MoveForward(Vector2 direction)
	{
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
	}
}
