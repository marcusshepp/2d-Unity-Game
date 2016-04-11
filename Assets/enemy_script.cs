using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class food_script : MonoBehaviour {

    private AudioSource audioSource;
    private AudioClip popSound;
    public Text textit;
    public Text time_remaining;
    public int time = 10;
    public int score = 0;
    public int priv_score = 0;
    public float enemy_one_pos_x = 0f;
    public float enemy_one_pos_y = .5f;
    public GameObject enemy_one;


    void OnCollisionEnter2D(Collision2D coll) {
        Debug.Log("TOUCHED");
        // GetComponent<AudioSource>().Play();

        // Vector2 food_position = new Vector2(Random.Range(-5f, 5f), Random.Range(-4f, 4f));
        // transform.position = food_position;

        score += 1;
        priv_score += 1;

        // Vector2 enemy_two_position = new Vector2(Random.Range(-5f, 5f), Random.Range(-4f, 4f));
        // enemy_two.transform.position = enemy_two_position;
    }
    IEnumerator MoveEnemy1(GameObject o){
        while (1 == 1){
            yield return new WaitForSeconds (.1f);
            // enemy_one_pos_x = enemy_one_pos_x - .2f;
            enemy_one_pos_y = enemy_one_pos_y - .2f;
            Vector2 enemy_one_position = new Vector2(o.transform.position.x, o.transform.position.y);
            o.transform.position = enemy_one_position;
            Debug.Log("moving");
        }
    }
    IEnumerator MoveEnemy2(GameObject o){
        while (1 == 1){
            yield return new WaitForSeconds (.1f);
            enemy_one_pos_x = enemy_one_pos_x - .2f;
            enemy_one_pos_y = enemy_one_pos_y - .2f;
            Vector2 enemy_one_position = new Vector2(enemy_one_pos_x, enemy_one_pos_y);
            o.transform.position = enemy_one_position;
            Debug.Log("moving");
        }
    }
    IEnumerator OneSecTimer(){
        while (1 == 1){
            yield return new WaitForSeconds (1f);
            time--;
        }
    }
    void newObstacle(){
        // Instantiate(enemy_one, new Vector2(Random.Range(-5f, 5f), Random.Range(-4f, 4f)), Quaternion.identity);
        priv_score = 0;
    }
    void Start () {
        // character_controller = GetComponent<CharacterController>();
        StartCoroutine(OneSecTimer());
        StartCoroutine(MoveEnemy1(enemy_one));
	}
	void Update () {
        textit.text = "Score: " + score;
        time_remaining.text = "Time: " + time;
        if ((priv_score % 5) == 0 && priv_score != 0){
            newObstacle();
            Debug.Log("FIVE");
        }
        if (time == 0){
            Debug.Log("TIME OUT");
            Application.LoadLevel("menu");
        }
	}
}
