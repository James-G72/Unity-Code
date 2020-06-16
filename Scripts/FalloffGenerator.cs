using UnityEngine;
using System.Collections;

public static class FalloffGenerator {
	// This generates a 2D map, hence the 2D float output that defines the fall off. This creates islands in the game

	public static float[,] GenerateFalloffMap(int size) {
		float[,] map = new float[size,size];

		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				float x = i / (float)size * 2 - 1;
				float y = j / (float)size * 2 - 1;

				float value = Mathf.Max (Mathf.Abs (x), Mathf.Abs (y)); // This simply gives us a value to pass into the function that will increse towards the middle
				map [i, j] = Evaluate(value); // Map is generated using the Evaluate method
			}
		}

		return map;
	}

	// This evaluate method provides the actual mathematical function to generate the map
	static float Evaluate(float value) {
		float a = 3; // These are fixed conatnts that create a sutable map
		float b = 2.2f;

		return Mathf.Pow (value, a) / (Mathf.Pow (value, a) + Mathf.Pow (b - b * value, a));
	}
}
