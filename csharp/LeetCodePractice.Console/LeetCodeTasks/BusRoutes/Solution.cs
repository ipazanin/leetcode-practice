// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.BusRoutes;

public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        var busStopsWithRoutes = CreateBusRoutesGraph(routes);

        var stopsWithNumberOfChangedRoutes = new Queue<(int stop, int numberOfChangedRoutes)>();
        stopsWithNumberOfChangedRoutes.Enqueue((source, 0));
        var visitedStops = new HashSet<int>();
        var visitedBuses = new HashSet<int>();

        while (stopsWithNumberOfChangedRoutes.TryDequeue(out var currentStopWithNumberOfChangedRoutes))
        {
            var (currentStop, numberOfChangedRoutes) = currentStopWithNumberOfChangedRoutes;

            if (currentStop == target)
            {
                return numberOfChangedRoutes;
            }

            var busRoutes = busStopsWithRoutes[currentStop];

            foreach (var busRoute in busRoutes)
            {
                if (visitedBuses.Contains(busRoute))
                {
                    continue;
                }

                visitedBuses.Add(busRoute);

                var busRouteStops = routes[busRoute];

                foreach (var busRouteStop in busRouteStops)
                {
                    if (visitedStops.Contains(busRouteStop))
                    {
                        continue;
                    }

                    visitedStops.Add(busRouteStop);

                    stopsWithNumberOfChangedRoutes.Enqueue((busRouteStop, numberOfChangedRoutes + 1));
                }
            }
        }

        return -1;
    }

    private static Dictionary<int, List<int>> CreateBusRoutesGraph(int[][] routes)
    {
        var busStopsWithRoutes = new Dictionary<int, List<int>>();

        for (var i = 0; i < routes.Length; i++)
        {
            for (var j = 0; j < routes[i].Length; j++)
            {
                var stop = routes[i][j];
                if (!busStopsWithRoutes.TryGetValue(stop, out var busRoute))
                {
                    busRoute = new();
                    busStopsWithRoutes.Add(stop, busRoute);
                }

                busRoute.Add(i);
            }
        }

        return busStopsWithRoutes;
    }
}
