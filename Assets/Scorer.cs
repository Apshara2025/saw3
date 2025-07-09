using UnityEngine;

public class Scorer : MonoBehaviour
{
    CollisionHandler myCollisionHandler;
    int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    private void OnCollisionEnter(Collision other)
    {
        myCollisionHandler = other.gameObject.GetComponent<CollisionHandler>();

        // if has a collision handler increase score
        if (myCollisionHandler != null && other.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("You've bumped into the obstacles this many times:" + score);
            other.gameObject.tag = "Hit";
        }
    }
}
