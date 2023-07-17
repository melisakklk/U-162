using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    Animator anim;
    public GameObject[] hearts;

    int life;

    private Rigidbody2D rb;
    

    //public GameObject other;
    public float damage;
    //public GameObject gHealthBar;
    



    private void Start()
    {
        
        //gHealthBar = GameObject.FindWithTag("HealthBar");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //  other.gameObject.
        damage = 10;
        life = hearts.Length;
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Traps"))
        {
            
           // Die();
        }
    }
    
    /*private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }
    */
    
    void CheckLife()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
            anim.SetTrigger("Hit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            anim.SetTrigger("Hit");

        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            anim.SetTrigger("Hit");

        }
    }
    public void PlayerDamaged()
    {
        life--;
        CheckLife();
        Debug.Log("can -1");

    }


    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    //public void UpdateHealth(float damage){
        //float CurrentHealth = gHealthBar.;
       // gHealthBar.value =CurrentHealth - damage;
    }

