using UnityEngine;
using System.Collections;

public class BeltLimitCollision : MonoBehaviour {
  public Transform stepSpawn;
  public GameObject step;

  void OnTriggerEnter(Collider other) {
    if(other.tag == "Step"){
      Destroy(other.gameObject);
      //tengo que spawnear un nuevo step en StepSpawn
      Instantiate(step, stepSpawn.position, Quaternion.identity);
    }
      

    
  }


}
