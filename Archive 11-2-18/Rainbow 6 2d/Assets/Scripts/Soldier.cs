using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    bool hover = false;
    bool selected = false;
    public static bool turnTaken = false;
    Vector3 newPosition;
    [SerializeField]
    private GameObject Cursor1;
    [SerializeField]
    private float moveDistance;
    
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!turnTaken && hover && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("selected");
 
            selected = true;
            
        }

        if (selected)
        {
            newPosition = Cursor1.transform.position;
            newPosition[0] -= .1f;
            newPosition[1] += .1f;
            newPosition[2] = .05f;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(.427f, .50f, .80f, 1f);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        if (selected && Input.GetKeyDown(KeyCode.Mouse0))
        {
            float distance = Mathf.Sqrt(Mathf.Pow(transform.position.x - newPosition.x, 2) + (Mathf.Pow(transform.position.y - newPosition.y, 2)));
            if (distance < moveDistance)
            {
                transform.position = newPosition;
                selected = false;
                turnTaken = true;
            }

            
        }
    }
    private void OnTriggerStay2D(Collider2D soldierC)

    {
        Debug.Log("in");
        if (soldierC.gameObject.CompareTag("Cursor1"))
        {
            hover = true;
            Debug.Log("hover");
        }
    }
}