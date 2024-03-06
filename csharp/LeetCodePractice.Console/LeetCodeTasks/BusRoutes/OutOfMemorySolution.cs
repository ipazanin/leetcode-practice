// OutOfMemorySolution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.BusRoutes;

public class OutOfMemorySolution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target)
        {
            return 0;
        }

        var busStopsWithRoutes = CreateBusRoutesGraph(routes);

        var minDistance = int.MaxValue;

        if (!busStopsWithRoutes.TryGetValue(source, out var sourceRoutes))
        {
            return -1;
        }

        if (!busStopsWithRoutes.TryGetValue(target, out var targetRoutes))
        {
            return -1;
        }

        foreach (var sourceRoute in sourceRoutes)
        {
            var minimalDistanceToTarget = GetMinimalDistanceToTarget(sourceRoute, targetRoutes);

            if (minimalDistanceToTarget < minDistance)
            {
                minDistance = minimalDistanceToTarget;
            }
        }

        return minDistance == int.MaxValue ? -1 : minDistance;
    }

    private static int GetMinimalDistanceToTarget(BusRoute sourceRoute, List<BusRoute> targetRoutes)
    {
        var visitedRoutes = new HashSet<BusRoute>();
        var routesToVisit = new Queue<(BusRoute route, int numberOfChangedRoutes)>();

        routesToVisit.Enqueue((sourceRoute, 1));

        var minDistance = int.MaxValue;

        while (routesToVisit.TryDequeue(out var routeWithNumberOfChangedRoutes))
        {
            var (currentRoute, numberOfChangedRoutes) = routeWithNumberOfChangedRoutes;

            if (visitedRoutes.Contains(currentRoute))
            {
                continue;
            }

            foreach (var targetRoute in targetRoutes)
            {
                if (currentRoute != targetRoute)
                {
                    continue;
                }

                if (numberOfChangedRoutes < minDistance)
                {
                    minDistance = numberOfChangedRoutes;
                }
            }

            visitedRoutes.Add(currentRoute);

            foreach (var connectedRoute in currentRoute.ConnectedNodes)
            {
                routesToVisit.Enqueue((connectedRoute, numberOfChangedRoutes + 1));
            }
        }

        return minDistance;
    }

    private static Dictionary<int, List<BusRoute>> CreateBusRoutesGraph(int[][] routes)
    {
        var busStopsWithRoutes = new Dictionary<int, List<BusRoute>>();

        foreach (var route in routes)
        {
            var busRoute = new BusRoute();

            foreach (var stop in route)
            {
                if (!busStopsWithRoutes.TryGetValue(stop, out var existingBusRoutesOnStop))
                {
                    existingBusRoutesOnStop = new();
                    busStopsWithRoutes.Add(stop, existingBusRoutesOnStop);
                }

                foreach (var existingBusRouteOnStop in existingBusRoutesOnStop)
                {
                    busRoute.ConnectedNodes.Add(existingBusRouteOnStop);
                    existingBusRouteOnStop.ConnectedNodes.Add(busRoute);
                }

                existingBusRoutesOnStop.Add(busRoute);
            }
        }

        return busStopsWithRoutes;
    }

    public class BusRoute
    {
        public List<BusRoute> ConnectedNodes { get; } = new();
    }
}
