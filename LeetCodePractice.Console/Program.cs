// using LeetCodePractice.Console.WeightedGraphs;

// public class Solution
// {
//     public int NumBusesToDestination(int[][] routes, int source, int target)
//     {

//     }

//     private Vertex<int, int> CreateVerticesFromRoutes(int[][] routes, int source, int target)
//     {

//         var sourceVertex = new Vertex<int, int>(source);
//         var targetVertex = new Vertex<int, int>(target);

//         var vertices = new Dictionary<int, Vertex<int, int>>
//         {
//             {source, sourceVertex},
//             {target, targetVertex},
//         };

//         foreach (var route in routes)
//         {
//             for (var i = 0; i < route.Length; i++)
//             {
//                 var currentValue = route[i];

//                 if (!vertices.TryGetValue(currentValue, out var currentVertex))
//                 {
//                     currentVertex = new Vertex<int, int>(currentValue);
//                     vertices[currentValue] = currentVertex;
//                 }

//                 if (i == 0)
//                 {
//                     var neighborValue = route[(i - 1) % route.Length];
//                     var neighborVertex = vertices[neighborValue];
//                     currentVertex.AddDoubleEdgeNeighbor(neighborVertex, 0);
//                 }
//             }
//         }
//     }
// }
