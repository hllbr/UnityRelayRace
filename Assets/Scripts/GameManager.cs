using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public RunnerController cube;
    public RunnerController sphere;
    public RunnerController cylinder;

    private int currentRunnerIndex = 0;
    private RunnerController[] runners;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        runners = new RunnerController[] { cube, sphere, cylinder };
        foreach (var runner in runners)
        {
            runner.ChangeColor(Color.yellow);
        }
        StartRace();
    }

    void StartRace()
    {
        runners[0].StartRunning();
    }

    public void NextRunner()
    {
        runners[currentRunnerIndex].ChangeColor(Color.red);

        if (currentRunnerIndex < runners.Length - 1)
        {
            currentRunnerIndex++;
            runners[currentRunnerIndex].StartRunning();
        }
        else if (currentRunnerIndex == runners.Length - 1)
        {
            StartReverseRace();
        }
    }

    void StartReverseRace()
    {
        // Cylinder geri d�n�yor
        cylinder.ChangeDirection();
        cylinder.StartRunning();
    }

    public void RunnerFinishedReturning(RunnerController runner)
    {
        if (runner == cylinder)
        {
            // Cylinder geri d�nmeyi tamamlad�, �imdi Sphere geri d�n�yor
            sphere.ChangeDirection();
            sphere.StartRunning();
        }
        else if (runner == sphere)
        {
            // Sphere geri d�nmeyi tamamlad�, �imdi Cube geri d�n�yor
            cube.ChangeDirection();
            cube.StartRunning();
        }
        else if (runner == cube)
        {
            // Cube ba�lang�� noktas�na d�nd�, t�m yar�� tamamland�
            EndRace();
        }
    }

    public void EndRace()
    {
        foreach (var runner in runners)
        {
            runner.ChangeColor(Color.yellow);
            runner.enabled = false;
        }
    }
}
