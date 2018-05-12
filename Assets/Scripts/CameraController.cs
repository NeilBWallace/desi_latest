using UnityEngine;

/* Makes the camera follow the player */


public class CameraController : MonoBehaviour {

	public Vector3 lookOffset = new Vector3(0,1,0);
	public float distance = 5;
	public float cameraSpeed=8;

	public Transform player;

	void Start(){
	}

	void Update()
	{
		Vector3 lookPosition = player.position + lookOffset;
		this.transform.LookAt (lookPosition);

		if (Vector3.Distance (this.transform.position, lookPosition) > distance) {
			this.transform.Translate (0, 0, cameraSpeed * Time.deltaTime);
		}
	}

}