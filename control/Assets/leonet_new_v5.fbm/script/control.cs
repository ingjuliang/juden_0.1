using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	public float speed = 30.0F;
	public float rotationSpeed = 300.0F;

	Animator animar;


	// Use this for initialization
	void Start () {
		animar = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
			//Play Running Animation
		if(Input.GetKey("up")==true||Input.GetKey("left")==true||Input.GetKey("right"))
		{
			float translation = Input.GetAxis("Vertical") * speed;
			float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
			translation *= Time.deltaTime;
			rotation *= Time.deltaTime;
			transform.Translate(0, 0, translation);
			transform.Rotate(0, rotation, 0);
			animar.Play("caminar");
		}

		if(Input.GetKey("w")==true)
		{
			float translation = Input.GetAxis("Vertical") * speed;
			float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
			translation *= Time.deltaTime;
			rotation *= Time.deltaTime;
			transform.Translate(0, 0, translation);
			transform.Rotate(0, rotation, 0);
			animar.Play("Correr");
		}


		if (Input.GetButtonDown ("Jump")) 
				{
						animar.SetBool ("saltar", true);
				} 
		else 
				{
						animar.SetBool("saltar",false);
				}

	}
}
