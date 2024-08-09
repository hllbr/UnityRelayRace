using UnityEngine;

public class RunnerController : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed = 5f;
    private bool isRunning = false;
    private bool isReturning = false;

    public void StartRunning()
    {
        isRunning = true;
        ChangeColor(Color.green);
    }

    public void StopRunning()
    {
        isRunning = false;
        ChangeColor(Color.red);
    }

    public void ChangeDirection()
    {
        // Geri dönmek için pozisyonlarý deðiþtir
        Vector3 temp = startPosition;
        startPosition = endPosition;
        endPosition = temp;
        isReturning = !isReturning;
    }

    void Update()
    {
        if (isRunning)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);

            if (transform.position == endPosition)
            {
                isRunning = false;
                ChangeColor(Color.red);

                if (isReturning)
                {
                    GameManager.Instance.RunnerFinishedReturning(this);
                }
                else
                {
                    GameManager.Instance.NextRunner();
                }
            }
        }
    }

    public void ChangeColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
