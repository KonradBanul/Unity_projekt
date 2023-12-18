using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float valueShift;
    public float speed;
    public float limitLeft;
    public float limitRight;
    public int hp = 5;
    public TMP_Text hpText;
    
    void Update()
    {
        if (hp <= 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        hpText.SetText(hp.ToString());
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > limitLeft) {
            targetPos = new Vector2(transform.position.x - valueShift, transform.position.y);
            
        } else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < limitRight) {
            targetPos = new Vector2(transform.position.x + valueShift, transform.position.y);
        }
    }
}
