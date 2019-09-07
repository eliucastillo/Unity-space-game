using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public int Score;
    public Transform Bullet;
    public Transform CannonPosition;
    public Text scoreText;
    public Text timer;
    public float timeLeft = 60f;
    public Slider mainSlider;
        
        
        
        
        
        void Start()
    {
        scoreText.text = "Marcador : "+ Score;
    }

    // Update is called once per frame
    void Update()
    {
        
        timeLeft -= Time.deltaTime;
        timer.text = (timeLeft).ToString("0");
         scoreText.text = "Marcador : "+ Score;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h, v, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Enemy"))
        {
            mainSlider.value -= 0.1f;
        }

    }

    void Shoot() {
        Instantiate(Bullet, CannonPosition.position, Quaternion.identity);
    }
}
