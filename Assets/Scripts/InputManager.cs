using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Bird bird;

    private void Start()
    {
        bird = FindObjectOfType<Bird>();
    }

    private void Update()
    {
        if (bird == null || !bird.IsAlive) return;

        // Keyboard input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bird.Flap();
        }

        // Mouse input
        if (Input.GetMouseButtonDown(0))
        {
            bird.Flap();
        }

        // Touch input for mobile
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                bird.Flap();
            }
        }
    }
}
