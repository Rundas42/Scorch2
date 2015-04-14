using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	public GameObject Enemy;
	public GameObject Portal;
	public GameObject Text;
	public float SpawnTimer;
	public float EnemySpawnCounter;
	
	void Spawn() {
		Vector3 newPosition = new Vector3(Random.insideUnitSphere.x * 50, transform.position.y, Random.insideUnitSphere.z * 50);
		Instantiate(Enemy, newPosition, transform.rotation);
		--EnemySpawnCounter;
	}
	// Use this for initialization
	void Start () {
		StartCoroutine(countdown(EnemySpawnCounter));
	}
	// Update is called once per frame
	void Update () {
		int enemyCount = GameObject.FindGameObjectsWithTag ("Enemy").Length;
		Debug.Log (enemyCount);
		if (enemyCount <= 0 && EnemySpawnCounter <= 0)
		{
			Text.SetActive(true);
			Portal.SetActive(true);
		}
	}

	IEnumerator countdown(float time)
	{
		int i = 0;
		while (i < time) {
			Spawn();
			yield return new WaitForSeconds(5.0f);
			--time;
		}

		/*if (time <= 0){
			//StartCoroutine(countdown(5));
			yield return null;
			if (EnemySpawnCounter > 0)
				Spawn();
		}
		else
		{
			yield return new WaitForSeconds(1);
			time--;
			//Spawn();
			print(time);
			StartCoroutine(countdown(time));
		}*/
	}
}