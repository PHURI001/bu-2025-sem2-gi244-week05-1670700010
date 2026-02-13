using UnityEngine;

public class WaveSpawnManager : MonoBehaviour
{
    public Wave[] waveConfigs;
    public WaveController waveController;

    private int currentWaveIdex = 0;
    private float waveEndTime = 0;

    void Start()
    {
        waveController.ChangeWave(waveConfigs[0]);
    }

    void Update()
    {
        if (waveController.IsCompleted())
        {
            currentWaveIdex++;
            if (currentWaveIdex < waveConfigs.Length)
            {
                waveController.ChangeWave(waveConfigs[currentWaveIdex]);
            }
            else
            {
                Debug.Log("All done");
            }
        }
    }
}