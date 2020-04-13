using UnityEngine;

public static class RandomState {
/// <summary>
///     Initialze the Unity random number generator with a new seed, and
///     return its previous state.
/// </summary>
/// <param name="seed">
///     The random seed for the new state of the Unity random number generator.
/// </param>
/// <returns>
///     The state of the Unity random number generator before it was initialized
///     with the seed value.
/// </returns>    
    public static Random.State Snapshot(int seed) {
        Random.State result = Random.state;
        Random.InitState(seed);
        return result;
    }
}