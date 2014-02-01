using UnityEngine;
using System.Collections;

public class BeltController : MonoBehaviour {

	void Update () {
	
	}
 
  void OnCollisionStay(Collision collisionInfo) {
    //collisionInfo.rigidbody.velocity = 10 * transform.right;
    collisionInfo.rigidbody.AddForce(Vector3.right*10);
  }


}
