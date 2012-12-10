using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	public Vector3 nextPosition;
	public ArrayList list;
	public Transform prefab;
	public int numberOfEnemies;
	public int recycleDistance;
	public int offset;
	public float speed;
	
	public float degrees;
	
	// Use this for initialization
	void Start () {
		Vector3 originalPosition = new Vector3(nextPosition.x,nextPosition.y,0);
		list = new ArrayList();
		for (int i = 0; i<numberOfEnemies; i++){
			Transform enemy = (Transform)Instantiate(prefab);
			enemy.Translate(originalPosition);
			originalPosition.x += offset;
			list.Add(enemy);
		}
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Transform e in list){
			if (e.gameObject.active == false){
				recycle(e);
			}
			if (e.localPosition.x < recycleDistance){
				e.gameObject.active = false;
			}else{
				
				float y = Mathf.Sin(e.localPosition.x)/(2*Mathf.PI);
				e.Translate(-speed * Time.deltaTime,y,0);
			}	
		}
	}
	
	void recycle(Transform e){	
		//Debug.Log("recylcing");
		e.localPosition = nextPosition;	
		e.gameObject.active=true;
	
	}
}
