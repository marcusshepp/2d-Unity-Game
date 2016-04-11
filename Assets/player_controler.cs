using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player_controler : MonoBehaviour {

    private float speed = 0.08f;
    public int time_remaining = 0;

    public GameObject bullet;

	void Start () {
        // character_controller = GetComponent<CharacterController>();
        StartCoroutine(OneSecTimer());
	}

    IEnumerator OneSecTimer(){
        while (1 == 1){
            yield return new WaitForSeconds (1f);
            time_remaining++;
        }
    }

	void Update () {
        ControllerMovement();
	}


    void ControllerMovement(){
        if (Input.GetKey(KeyCode.Space)){
            Debug.Log("Space");
            Instantiate(bullet);
        }
        if (Input.GetButton("360_DPadUp")){
            Debug.Log("UP");
            MoveUp();
        }
        if (Input.GetButton("360_DPadDown")){
            MoveDown();
        }
        if (Input.GetButton("360_DPadLeft")){
            MoveLeft();
        }
        if (Input.GetButton("360_DPadRight")){
            MoveRight();
        }
        if (Input.GetButton("360_AButton")){
            Debug.Log("A BUTTON!");
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            MoveRight();
        } else if (Input.GetKey(KeyCode.LeftArrow)){
            MoveLeft();
        } else if (Input.GetKey(KeyCode.UpArrow)){
            MoveUp();
        } else if (Input.GetKey(KeyCode.DownArrow)){
            MoveDown();
        }
    }

    void MoveRight(){
        Vector2 position = transform.position;
        position.x += speed;
        transform.position = position;
    }
    void MoveLeft(){
        Vector2 position = transform.position;
        position.x -= speed;
        transform.position = position;
    }
    void MoveUp(){
        Vector2 position = transform.position;
        position.y += speed;
        transform.position = position;
    }
    void MoveDown(){
        Vector2 position = transform.position;
        position.y -= speed;
        transform.position = position;
    }
}
