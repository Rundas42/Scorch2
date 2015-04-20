﻿using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	//public Portal portal;
	public GameObject Enemy;
	public GameObject Portals;
	public GameObject Text;
	public float SpawnTimer;
	public float EnemySpawnCounter;
	public float Level;
	
	void Spawn() {
		Vector3 newPosition = new Vector3(Random.insideUnitSphere.x * 50, transform.position.y, Random.insideUnitSphere.z * 50);
		Instantiate(Enemy, newPosition, transform.rotation);
		--EnemySpawnCounter;
	}
	// Use this for initialization
	void Start () {
		//Level = Portal.
		StartCoroutine(countdown(EnemySpawnCounter));
	}
	// Update is called once per frame
	void Update () {
		int enemyCount = GameObject.FindGameObjectsWithTag ("Enemy").Length;
		Debug.Log (enemyCount);
		if (enemyCount <= 0 && EnemySpawnCounter <= 0)
		{
			Text.SetActive(true);
			Portals.SetActive(true);
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
	}
}