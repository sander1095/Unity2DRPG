using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject targetToFollow;
    private Vector3 targetPosition;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        targetPosition = new Vector3(targetToFollow.transform.position.x, targetToFollow.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
	}
}
