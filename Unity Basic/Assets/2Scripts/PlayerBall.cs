using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int score;
    public GameManagerLogic manager; //Find 안쓰기 위함.
    bool isJump;
    Rigidbody rigid;
    AudioSource audio1;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio1 = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJump = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            score++;
            audio1.Play();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Finish")
        {
            if(score == manager.totalItemCount){
                //Game clear! && Next Stage
                if (manager.stage == 2)
                    SceneManager.LoadScene(0);
                else
                    SceneManager.LoadScene(manager.stage + 1);
            }
            else {
                //Restart

                SceneManager.LoadScene(manager.stage);
            }
        }
    }
}
