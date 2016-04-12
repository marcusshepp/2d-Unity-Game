using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class goal : MonoBehaviour {

    private AudioSource audioSource;
    private AudioClip popSound;
    public Text textit;
    public Text time_remaining;
    public int time = 25;
    public int score = 0;
    public int priv_score = 0;

	void Start () {
        StartCoroutine(OneSecTimer());
	}

    void OnCollisionEnter2D(Collision2D coll) {
        Debug.Log("TOUCHED");
        // GetComponent<AudioSource>().Play();


        priv_score += 1;
        if (coll.gameObject.name == "player"){
            score += 1;
            if (Application.loadedLevel == 1){
                Debug.Log("ONE");
                Application.LoadLevel(2);
            } else if(Application.loadedLevel == 2) {
                Application.LoadLevel(3);
            } else if(Application.loadedLevel == 3) {
                Application.LoadLevel(4);
            }
        } else {
            // Application.LoadLevel(Application.loadedLevel);
        }
    }
    void OnLevelWasLoaded(int level){
        Debug.Log(level);
    }
    IEnumerator OneSecTimer(){
        while (1 == 1){
            yield return new WaitForSeconds (1f);
            time--;
        }
    }
	// Update is called once per frame
	void Update () {

        textit.text = "Score: " + score.ToString();
        time_remaining.text = "Time: " + time;
        if ((priv_score % 5) == 0 && priv_score != 0){
            // newObstacle();
        }
        if (time == 0){
            Application.LoadLevel("menu");
        }
	}
}
