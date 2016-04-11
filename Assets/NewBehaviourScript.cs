using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    private AudioSource audioSource;
    private AudioClip popSound;
    public Text textit;
    public Text time_remaining;
    public int time = 25;
    public int score = 0;
    public int priv_score = 0;
    // enemies
    public GameObject enemy_one;
    public GameObject enemy_two;
    public GameObject enemy_three;
    public GameObject enemy_four;


    void OnCollisionEnter2D(Collision2D coll) {
        Debug.Log("TOUCHED");
        // GetComponent<AudioSource>().Play();
        score += 1;
        priv_score += 1;
    }
    IEnumerator MoveDown(GameObject o, float time_after_start, float pixel_movement){
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
    IEnumerator OneSecTimer(){
        while (1 == 1){
            yield return new WaitForSeconds (1f);
            time--;
        }
    }
    void newObstacle(){
        priv_score = 0;
    }
    void Start () {
        StartCoroutine(OneSecTimer());
        StartCoroutine(MoveDown(enemy_one, 1.5f, .2f));
        StartCoroutine(MoveDown(enemy_two, 1.2f, .2f));
        StartCoroutine(MoveDown(enemy_three, .5f, .2f));
        StartCoroutine(MoveDown(enemy_four, .7f, .2f));
	}
	void Update () {
        textit.text = "Score: " + score.ToString();
        // Debug.Log(textit.text);
        time_remaining.text = "Time: " + time;
        if ((priv_score % 5) == 0 && priv_score != 0){
            newObstacle();
            // Debug.Log("FIVE");
        }
        if (time == 0){
            // Debug.Log("TIME OUT");
            Application.LoadLevel("menu");
        }
	}
}
