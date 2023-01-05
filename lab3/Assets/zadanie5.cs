using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5 : MonoBehaviour
{
    // Prefab for the cube game object
    public GameObject cubePrefab;

    // Number of cubes to generate
    public int numCubes = 10;

    // Size of the plane
    public float planeSize = 10.0f;

    // Flag to control when the cube generation should be active
    public bool gameActive = false;

    void Start()
    {
        // Generate the cubes
        for (int i = 0; i < numCubes; i++)
        {
            // Generate a random position within the plane
            Vector3 randomPosition = new Vector3(Random.Range(-planeSize / 2, planeSize / 2),
                                                0,
                                                Random.Range(-planeSize / 2, planeSize / 2));

            // Check if there is already a cube at the generated position
            bool positionTaken = Physics.CheckBox(randomPosition, Vector3.one / 2);

            // If the position is not taken, instantiate a new cube at the position
            if (!positionTaken)
            {
                Instantiate(cubePrefab, randomPosition, Quaternion.identity);
            }
            // If the position is taken, try again with a new random position
            else
            {
                i--;
            }
        }
    }
}