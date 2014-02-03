using UnityEngine;
using System.Collections;

public class BeltStep : MonoBehaviour {
	public float speed;

  void Update(){
    transform.Translate(Time.deltaTime * speed, 0,0 );
  }

}
