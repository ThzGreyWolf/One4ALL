using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour {
    public GameObject mazeCellPrefab;
    public int mazeWidth, mazeHeight, mazeDepth; // NOTE: mazeHeight is for future use maybe
    public int mazeXDist, mazeYDist, mazeZDist;

    private void Start() {
        for (int x = 0; x < mazeWidth; x++) {
            for (int y = 0; y < mazeHeight; y++) {
                for (int z = 0; z < mazeDepth; z++) {
                    GameObject.Instantiate(mazeCellPrefab, new Vector3(x * mazeXDist, y * mazeYDist, z * mazeZDist), Quaternion.identity);
                }
            }
        }
    }
}
