using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    
    public float defaultSpeed = 10f;
    public float dashSpeed = 20f;
    public float dashDelay = 0.5f;
    float moveSpeed;

	private void Start()
	{
        moveSpeed = defaultSpeed;
	}
	
	void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Dash();

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);        
    }

    void Dash()
	{
        if (Input.GetButtonDown("Jump")){
            moveSpeed = dashSpeed;
            StartCoroutine(ResetPlayerSpeed(dashDelay));
        }
	}

    IEnumerator ResetPlayerSpeed(float delay)
	{
        yield return new WaitForSeconds(delay);

        moveSpeed = defaultSpeed;
    }
}
