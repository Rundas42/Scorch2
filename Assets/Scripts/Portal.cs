using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	public GameObject levelPortal;
	public GameObject MoveOn;
	void Start () {
		levelPortal.SetActive (false);
	}
	public void OnTriggerEnter(){
		MoveOn.SetActive(true);
	}
	void Update () {
        if (levelPortal.activeInHierarchy){

            if (Input.GetKeyDown(KeyCode.E))
            {
                int num;
                num = Random.Range(1, 4);

                Application.LoadLevel(Random.Range(num, Application.levelCount -1));
            }
        }
	}
}
