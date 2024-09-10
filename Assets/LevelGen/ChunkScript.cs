using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ObstacleType
{
    Train = 0,
    JumpBarricade = 1,
    RollBarricade = 2,
}

public class ChunkScript : MonoBehaviour
{
    [SerializeField] private GameObject[] Lanes;

    [SerializeField] private GameObject[] ObstaclePrefabs;

    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += LevelGenerator.Instance.WorldSpeed * Time.deltaTime;
        transform.position = newPosition;

        if (transform.position.x > 55.0f)
        {
            Destroy(gameObject);
            LevelGenerator.Instance.SpawnChunk(new Vector3(-145.0f, -1.5f, 0.0f));
        }
    }

    public void AddObstacle(ObstacleType obstacle, int lane, int forwardOffset)
    {

        Vector3 Location = transform.position;

        float heightOffset = 0.0f;

        switch (obstacle)
        {
            case ObstacleType.Train:
                heightOffset = 2.0f;
                break;
            case ObstacleType.JumpBarricade:
                heightOffset = 1.0f;
                break;
            case ObstacleType.RollBarricade:
                heightOffset = 1.0f;
                break;

        }

        Location.x += 50.0f - forwardOffset;
        Location.y += heightOffset;
        Location.z += -2 + lane * 2;

        GameObject Obstacle = Instantiate(ObstaclePrefabs[(int)obstacle], Location, Quaternion.identity);
        Obstacle.transform.SetParent(transform, true);

    }


}