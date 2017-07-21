using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaker : MonoBehaviour {
	public int sizeX;
	public int sizeY;
	public GameObject A;
	public GameObject B;
	public GameObject C;
	public List<GameObject> objs = new List<GameObject>();
	void Start () {
		MakeGrid ();
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			DestroyRows ();
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			for (int i = 0; i < objs.Count; i++) {
				if (objs [i] == null) {
					
				}
			}
		}
	}
	void MakeGrid(){
		for (int y = 0; y < sizeY; y++) {
			for (int x = 0; x < sizeX; x++) {
				int randNumb = Random.Range (1, 4);
				switch (randNumb) {
				case 1:
					SpawnObject (A, x, y);
					break;
				case 2:
					SpawnObject (B, x, y);
					break;
				case 3:
					SpawnObject (C, x, y);
					break;
				default:
					break;
				}
			}
		}
	}
	void RefillGrid(){

	}
	void DestroyRows(){
		List<GameObject> tempObjs = new List<GameObject> ();
		List<int> deletedIndexes = new List<int> ();
		List<Transform> deletedPositions = new List<Transform> ();
		/*for (int i = 0; i < objs.Count; i++) {
			if(i >= 10 && i <= 89){
				if (objs [i] == null) {
					print ("dont do this part");
					return;
				} else {
					if (objs [i].name == objs [i + sizeY].name && objs [i].name == objs [i - sizeY].name) {
						deletedIndexes.Add (i);
						deletedIndexes.Add (i - sizeY);
						deletedIndexes.Add (i + sizeX);
						deletedPositions.Add (objs [i].transform);
						deletedPositions.Add (objs [i - sizeY].transform);
						deletedPositions.Add (objs [i + sizeY].transform);
						Destroy (objs [i]);
						Destroy (objs [i - sizeY]);
						Destroy (objs [i + sizeY]);
						objs [i] = null;
						objs [i - sizeY] = null;
						objs [i + sizeY] = null;
					}
				}
			}
		}*/
		for (int i = 0; i < objs.Count; i++) {
			if (i >= 0 && i <= 97) {
				if (objs [i].name == objs [i + 1].name && objs[i].name == objs[i + 2].name) {
					tempObjs.Add (objs [i]);
					tempObjs.Add (objs [i + 1]);
					tempObjs.Add (objs [i + 2]);
				} 
				if (objs [i].name == objs [i + 1].name && objs[i].name == objs[i + 2].name && objs[i].name == objs[i + 3].name) {
					tempObjs.Add (objs [i]);
					tempObjs.Add (objs [i + 1]);    
					tempObjs.Add (objs [i + 2]);
					tempObjs.Add (objs [i + 3]);
				}
				if (objs [i].name == objs [i + 1].name && objs[i].name == objs[i + 2].name && objs[i].name == objs[i + 3].name && objs[i].name == objs[i + 4].name) {
					tempObjs.Add (objs [i]);
					tempObjs.Add (objs [i + 1]);
					tempObjs.Add (objs [i + 2]);
					tempObjs.Add (objs [i + 3]);
					tempObjs.Add (objs [i + 4]);
				} 
			}
		}
		for (int i = 0; i < tempObjs.Count; i++) {
			Destroy (tempObjs [i]);
		}
		print (tempObjs.Count + "eyo");
	}
	void SpawnObject(GameObject obj, int x, int y) {
		GameObject inst = Instantiate (obj, new Vector3 (x, y, 0), Quaternion.identity);
		objs.Add (inst);
	}
}
