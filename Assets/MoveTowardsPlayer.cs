
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float moveSpeed = 100f;

    void Awake()
    {
        gameObject.SetActive(false);
    } 
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, moveSpeed * Time.deltaTime);
    }
}
