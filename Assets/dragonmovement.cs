using UnityEngine;

public class dragonmovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5;

    private float ratimer = 0, fireballtimer = 0;

    private float ratwait = 3;

    private float fireballwait = 3;

    public GameObject rat;

    public GameObject fireball;
    private bool goingUp = true;

    // Update is called once per frame
    void Update()
    {
        ratimer += Time.deltaTime;
        fireballtimer += Time.deltaTime;

        if (ratimer > ratwait)
        {
            Instantiate(rat, transform.position, Quaternion.identity);
            ratimer = 0;
            ratwait = Random.Range(1F, 3F);
        }
        if (fireballtimer > fireballwait)
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
            fireballtimer = 0;
            fireballwait = Random.Range(1F, 3F);
        }
        transform.Translate(transform.up * speed * Time.deltaTime);
        if (transform.position.y > 4 && goingUp == true)
        {
            goingUp = false;
            speed *= -1;
        }
        if (transform.position.y < -4 && goingUp == false)
        {

            goingUp = true;
            speed *= -1;
        }
        
    }
}
