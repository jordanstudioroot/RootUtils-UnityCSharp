using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RootUtils.Randomization {
    /// <summary>
    /// A serializeable hash value for storing persistent
    /// random values.
    /// </summary>
    public struct RandomHash {
        private float[] values;

    /// <summary>
    /// The number of values in the hash.
    /// </summary>
        public int Length {
            get {
                return values.Length;
            }
        }

    /// <summary>
    /// The average value of all values in the hash.
    /// </summary>
        public float Average {
            get {
                float result = 0;

                for (int i = 0; i < values.Length; i++) {
                    result += values[i]/values.Length;
                }

                return result;
            }
        }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="size">The size of the list of random values.</param>
        public RandomHash(int size) {
            values = new float[size];

            for (int i = 0; i < size; i++) {
                values[i] = Random.value * 0.999f;
            }
        }

    /// <summary>
    /// Get the value in the hash and the specified index.
    /// </summary>
    /// <param name="index">The index of the desired value.</param>
    /// <returns>The value at the specified index.</returns>
    /// <exception cref="System.IndexOutOfRangeException">
    ///     Thrown if specified index is no in the range of the initally generated
    ///     hash values.
    /// </exception>
        public float GetValue(int index) {  
            if (values.Length > index) {
                return values[index];
            }

            throw new System.IndexOutOfRangeException();
        }

    /// <summary>
    /// Serializes the hash list to a file in Application.persistentDataPath
    /// </summary>
    /// <param name="name">The desired name of the target file.</param>
        public void Serialize(string name) {
            throw new System.NotImplementedException();
        } 
    } 
}
