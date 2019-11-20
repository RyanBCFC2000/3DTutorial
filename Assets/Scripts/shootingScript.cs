    using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shootingScript : MonoBehaviour
{
    [SerializeField] int damageDealt = 20;
    [SerializeField]
    LayerMask layermask;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
        layermask |= Physics.IgnoreRaycastLayer;
        layermask = ~layermask;

    }


    public GameObject losePanel;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetButtonDown ("Fire1"))
        {
            //Make a raycast with the line starting from center of camera
            if(!losePanel.activeInHierarchy)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;
            //Send the raycast and if the raycast hits something, print out the name to console
            if (Physics.Raycast (mouseRay, out hitInfo, 100, layermask))
            {
                print(hitInfo.transform);
                Debug.DrawLine(transform.position, hitInfo.point, Color.red, 5.0f);
                HealthScript enemyHealth = hitInfo.transform.GetComponent<HealthScript>();
                if (enemyHealth != null)
                {
                    enemyHealth.Damage(damageDealt); //If enemy gets hit it takes damage 
                }
                
            }
        }
    }
}
