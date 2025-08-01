using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject axe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            axe.SetActive(true);
            Destroy(gameObject);
        }
    }
}
