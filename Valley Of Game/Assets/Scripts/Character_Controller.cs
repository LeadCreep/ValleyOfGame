using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character_Controller : MonoBehaviour
{

    PlayerControls controls;

    Vector2 move;
    
    public float defaultSpeed = 5f;
    public float runSpeed = 10f;
    float moveSpeed;


	private void Awake(){
        controls = new PlayerControls();

        controls.Gameplay.Run.performed += ctx => Run();
        controls.Gameplay.Run.canceled += ctx => DeRun();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    }

    void OnEnable(){
        controls.Gameplay.Enable();
	}

	private void OnDisable(){
        controls.Gameplay.Disable();
	}

	private void Start()
	{
        moveSpeed = defaultSpeed;
	}
	
	void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime * moveSpeed;
        transform.Translate(m);        
    }

    void Run()
	{
        moveSpeed = runSpeed;
	}

    void DeRun()
	{
        moveSpeed = defaultSpeed;
	}
}
