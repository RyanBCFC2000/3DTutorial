using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform playerMode1;
    CharacterController controller;

    [SerializeField] float moveSpeed = 5.0f;
    public float h;
    public float v;

    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        playerMode1 = playerGameObject.transform;
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 direction = playerMode1.position - transform.position;
        controller.Move(direction * Time.deltaTime);

    }
}
