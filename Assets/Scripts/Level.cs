using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Serialized for debugging
    [SerializeField] int breakableBlocks;

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
}
