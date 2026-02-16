using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Making public variables allows you to adust it in unity
    public float speed = 1.0f;
    public float jumpHeight = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        //Right movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Get currentposition
            Vector2 curPosition = gameObject.transform.position;

            //Get new position
            Vector2 newPosition = new Vector2(curPosition.x + Time.deltaTime * speed, curPosition.y);

            //Update the position
            gameObject.transform.position = newPosition;
        }

        //Left movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Get currentposition
            Vector2 curPosition = gameObject.transform.position;

            //Get new position
            Vector2 newPosition = new Vector2(curPosition.x - Time.deltaTime * speed, curPosition.y);

            //Update the position
            gameObject.transform.position = newPosition;
        }

        //Jump movement
        if (Input.GetKey(KeyCode.Space))
        {
            int hangtime = 5;
            while (hangtime > 0)
            {
                //Get currentposition
                Vector2 curPosition = gameObject.transform.position;

                //Get new position
                Vector2 newPosition = new Vector2(curPosition.x, curPosition.y + Time.deltaTime * speed);

                //Update the position
                gameObject.transform.position = newPosition;
                hangtime--;
            }
        }
    }
}
