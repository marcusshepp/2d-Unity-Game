using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    // enemies
    public GameObject enemy_one;
    public GameObject enemy_two;
    public GameObject enemy_three;
    public GameObject enemy_four;
    public GameObject enemy_5;
    public GameObject enemy_6;
    public GameObject enemy_7;
    public GameObject enemy_8;
    public GameObject enemy_9;
    public GameObject enemy_10;
    public GameObject enemy_11;
    public GameObject enemy_12;
    public GameObject enemy_13;
    public GameObject enemy_14;

    void OnCollisionEnter2D(Collision2D theCollision) {
        // Debug.Log("TOUCHED");
        // GetComponent<AudioSource>().Play();
        if (theCollision.gameObject.name.Contains("enemy")){
            Debug.Log("ENEMY!!");
            Application.LoadLevel(Application.loadedLevel);
        }

    }
    IEnumerator MoveEnemy(GameObject o, float time_after_start, float pixel_movement){
        while (1 == 1){
            yield return new WaitForSeconds (time_after_start);
            float new_enemy_pos_y;
            float current_x =  o.transform.position.x;
            float current_y =  o.transform.position.y;
            if(current_y < -3.4f){
                // if at bottom of screen
                new_enemy_pos_y = 2.78f;
            } else {
                new_enemy_pos_y = current_y - pixel_movement;
            }
            Vector2 new_enemy_one_position = new Vector2(current_x, new_enemy_pos_y);
            o.transform.position = new_enemy_one_position;
            // Debug.Log("moving");
        }
    }
    IEnumerator MoveEnemy2(GameObject o){
        while (1 == 1){
            yield return new WaitForSeconds (.1f);
            // Debug.Log("moving");
        }
    }

    // void newObstacle(){
        // priv_score = 0;
    // }
    void Start () {


        // MoveEnemy(GameObject o, float time_after_start, float pixel_movement)
        StartCoroutine(MoveEnemy(enemy_one,      7f, 1f));
        StartCoroutine(MoveEnemy(enemy_two,      1f, 1f));
        StartCoroutine(MoveEnemy(enemy_three,    7f, 1f));
        StartCoroutine(MoveEnemy(enemy_four,     1f, 1f));
        StartCoroutine(MoveEnemy(enemy_5,        7f, 1f));
        StartCoroutine(MoveEnemy(enemy_6,        3f, 1f));
        StartCoroutine(MoveEnemy(enemy_7,        3f, 1f));
        StartCoroutine(MoveEnemy(enemy_8,        3f, 1f));
        StartCoroutine(MoveEnemy(enemy_9,        7f, 1f));
        StartCoroutine(MoveEnemy(enemy_10,       3f, 1f));
        StartCoroutine(MoveEnemy(enemy_11,       1f, 1f));
        StartCoroutine(MoveEnemy(enemy_12,       1f, 1f));
        StartCoroutine(MoveEnemy(enemy_13,       3f, 1f));
        StartCoroutine(MoveEnemy(enemy_14,       3f, 1f));
	}
	void Update () {

	}
}
