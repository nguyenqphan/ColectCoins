using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	
	[SerializeField]
	private float rotateSpeed = 1.0f; // In rotations per second
	
	// Use this for initialization
	void Start () {
		transform.Rotate (transform.up, Random.Range(0f, 360f));
		StartCoroutine (Spin ());
	}
	
	private IEnumerator Spin()
	{
		while (true)
		{
			transform.Rotate (transform.up, 360 * rotateSpeed * Time.deltaTime);
			yield return 0;
		}
	}
}
