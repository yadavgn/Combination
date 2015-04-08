using System.Collections.Generic;

public class CandidateCode
{
    static Dictionary<int, List<int>>  graph = new Dictionary<int, List<int>>(); // representation of dictionary not and its connection.
    
	public static int maxno_city(string[] input1)
	{
		//Write code here
	    CreateGraph(input1);
	    int maxVisitCnt = 0;
        List<int> Visited_cities = new List<int>();
	    foreach (var city in graph.Keys)
	    {
            Visited_cities.Clear();
	        int visit_cnt = Visit(city, Visited_cities); // visit 
	        if (maxVisitCnt < visit_cnt) maxVisitCnt = visit_cnt;
	    }

        return maxVisitCnt;
	}

    private static bool Visited(int city, List<int> visitedcites )
    {
        return visitedcites.Contains(city);
    }

    // visit the city. list of visited cities does not contains current city being visited.
    private static int Visit(int city, List<int> visitedcites)
    {
        if (visitedcites.Contains(city)) return 0;
        int maxVisitLenght = 0, visit_cnt=0;
        visitedcites.Add(city); // mark current city as visited
        foreach (var next_city in graph[city])
        {
            if (!Visited(next_city, visitedcites))
            {
                visit_cnt = Visit(next_city, visitedcites);
                if (visit_cnt > maxVisitLenght) maxVisitLenght = visit_cnt;
            }
        }
        visitedcites.Remove(city); // un-mark current city as visited. so that it can be visited next time.

        return 1 + maxVisitLenght; // 1 is added for current city visit.
    }

    // its an adjacency list implementation.
    private static void CreateGraph(string[] input1)
    {
        foreach (var str in input1)
        {
            // Note invalid input scenarios are not handled here.
            string[] cityConnection = str.Split('#');
            int city1 = int.Parse(cityConnection[0]);
            int connectedCity = int.Parse(cityConnection[1]);

            if (!graph.ContainsKey(city1))
            {
                graph.Add(city1, new List<int>());
            }


            if (!graph[city1].Contains(connectedCity))
                graph[city1].Add(connectedCity);

            if (!graph.ContainsKey(connectedCity))
            {
                graph.Add(connectedCity, new List<int>());
            }
            if (!graph[connectedCity].Contains(city1))
                graph[connectedCity].Add(city1);
        }
    }
}
