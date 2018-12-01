using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDisplay : MonoBehaviour {

    public Monster goblin;
    public GameObject player;
    Vector2 direction;
	// Use this for initialization
	/*void Start () {
		
	}*/
    void Update() {
        direction = player.transform.position - transform.position;
        direction = direction.normalized;
    }


}
