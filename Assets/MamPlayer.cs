using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MamPlayer : MonoBehaviour
{

    Vector3 mousePosition;
    Vector3 cameraMousePosition;

    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        cameraMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        cameraMousePosition.z = 0;
        cameraMousePosition.y = transform.position.y;
        transform.position = cameraMousePosition;

        cameraMousePosition.x = Mathf.Clamp(cameraMousePosition.x, -7.0f, 7.0f);
        transform.position = cameraMousePosition;
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            score += 10;

            Destroy(other.gameObject,0.1f);
        }
    }
}
