using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {

	public GameObject applePrefab;

	public float speed = 1f;

	//Distance where Appletree turns around
	public float leftAndRightEdge = 10f;
	//chance that the Appletree will change directions
	public float chanceToChangeDirections = 0.1f;
	//rate at which our apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}

	void DropApple()
	{
		GameObject apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		//direction
		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed); //move right
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed); //move left
		}
	}
	void FixedUpdate()
	{
		//change direction random
	 	if (Random.value < chanceToChangeDirections) {
			speed *= -1; 
		}	
	}
}
