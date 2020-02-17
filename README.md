# RootUtils

A library of functions used by Studio Root Games in various projects. Includes various functions that could not otherwise be implemented as extensions on existing Unity classes. Can be directly copied into a project, turned into a Unity Package Manager Package, or imported into the project directly using [UnityNPMInit](https://github.com/jordanstudioroot/UnityNPMInit).

# Requirements

# Usage
All functions are static, and can be called directly from their corresponding class. Ex. `Bezier.GetQuadradicPoint(Vector3 a, Vector3 b, Vector3 c, float t)`.

# Overview
- Bezier: Methods for calculating Bezier curves.
- DebugUtils: Methods for debugging.
- Detect: Methods for implementing detection algoritms.
- Distance: Methods for calculating distance.
- EventSystemUtils: Methods for interacting with Unity's Event System.
- ScreenPoint: Methods for relating a 2D screen point to screen space and world space.
- UnityBuiltin: Methods for retrieving built in Unity assets.

# Recommendations

# TODO
- [ ] Add namespaces.
- [ ] Tests
