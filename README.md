# REST and SOAP WS Lab

   ## Introduction

   VelibIWS includes all parts of this Lab. 

   VelibSoapIWS is the IWS, VelibConsoleClient is the first and minimal client console application, GuiClientWS is the GUI client application, GUIMonitor is the GUI client application for monitoring.

   Please run the VelibSoapIWS in VS as Admin. The function of monitoring uses the port 8734 and the function of IWS uses the port 8733, please make sure that they aren't occupied.

   ## Basic Functions

   1. There are two parts in this project, a local **Intermediary Web Service** that expose a WS-SOAP API to clients to access to the Velib Web Service and a **Client Application**.
   2. The IWS API provides three services:
      - GetHelp: The client can get some instructions on how to use this client application
      - GetStationsOfACity: The client input the name of a city, then he can get all the names of the Velib stations in this city
      - GetStationInfo: The client input the name of a city and the name of a station, then he can get the full information of this station
   3. This service can distinguish the errors of the input of the client (the name of the city or of the station doesn't exist etc).

   ## Extensions

   1. **A GUI client application**

      This GUI is simple but clear. The client can choose a service, input the required information and get the result from WS server.

   2. **All the accesses are asynchronous**

      For the accesses between IWS and Velib WS, I used `await request.GetResponseAsync();` to get async response, and return a Task \<string> to client. The method is also async.

      For the accesses between IWS and WS Client, I used the asynchronous methods generated by WCF reference in WS Client. For exemple, for the service **GetStationInfo**, I added an Event to the GetStationStationInfoCompleted:

      ```c#
      client.GetStationInfoCompleted += delegate (object sender, GetStationInfoCompletedEventArgs args)
      {
      	result = args.Result; //Get the result from server
      	CreateResultPanel(); //Update the GUI to show the result
      };
      ```

      When the client click the confirm button:

      ```c#
      client.GetStationInfoAsync(cityTextBox.Text, stationTextBox.Text); //cityTextBox.Text is the name of the city, stationTextBox.Text is the name of the station
      ```

      The client waits for the result. If this action is completed, the GUI will show the result.

   3. **Add a cache in IWS**

      To add a cache, I've created two MemoryCache in IWS, one for the information of the cities and another for the information of the stations. Every time the client sends a request, the IWS will check if the result to the request is in the cache, if so, IWS will send this result to the client, if not, IWS will connect to Velib WS to get the information and add the information in the cache for the same request. The policy for these cache is SlidingExpiration, the cache will be saved for 30 minutes.

      ```c#
      ObjectCache cacheCity;
      ObjectCache cacheStation;
      CacheItemPolicy policy;

      ...
          
      cacheCity = MemoryCache.Default;
      cacheStation = MemoryCache.Default;
      policy = new CacheItemPolicy();
      policy.SlidingExpiration = new TimeSpan(0, 30, 0);

      ...
          
      if (cacheStation[station] != null)
      {
      	return (string)cacheStation[station];
      }

      ...
          
      cacheStation.Set(station, a.ToString(), policy);

      ...
      ```

   4. **Monitor**

      The server of IWS provides an interface of monitoring the condition of server. An Gui client application can access to this Monitor WS remotely.

      There are four functions for Monitor WS

      1. Get the average of delay
      2. Get the number of requests from clients to this IWS during a specific period
      3. Get the number of requests to the Velib server during a period
      4. Get the number of caches on IWS

   ## How to test?

   1. Run the IWS first

   2. Run the console client application in another computer

      ![](img/2.jpg)

   3. Select 1 to list all the stations of a city

      ![](img/3.jpg)

      Because it's the first time to search for Toulouse, there is no cache for it, so it spent more time

   4. Select 1 again to search for Toulouse, because this time there is a cache for Toulouse, it's faster to get the response

   5. Select 2 to search for a station in a city

      ![](img/5.jpg)

   6. Select 3 to get help

      ![](img/6.jpg)

   7. If we don't input a right city name or a station name, the system will detect it

      ![](img/7.jpg)

      ![](img/7.2.jpg)

      ![](img/7.3.jpg)

   8. Now we can test the monitor. Util now, there are 2 caches, 5 requests from client, 4 requests to Velib server (including 2 request with invalid city and station)

      ![](img/8.jpg)

      First we get the average of delay

      ![](img/8.2.jpg)

      Then we get the number of requests from client, we choose the period from 19:10 to 19:31

      ![](img/8.3.jpg)

      So it shows what we have expected

      ![](img/8.4.jpg)

      Then we get the number of requests to Velib

      ![](img/8.5.jpg)

      Then we test the number of caches

      ![](img/8.6.jpg)

      If we input a invalid period, the server will return un error

      ![](img/8.7.jpg)

      ![](img/8.8.jpg)

   9. Then we test the GUI Client Application

      ![](img/9.jpg)

      First we choose to list all stations of a city, we choose Nancy

      ![](img/9.1.jpg)

      Then we list the information of a station of nancy

      ![](img/9.2.jpg)

      ![](img/9.3.jpg)

      We can also get help

      ![](img/9.4.jpg)

      If we input invalid city or station, it will also return an error

      ![](img/9.5.jpg)

   10. Now we can test Monitor again

       ![](img/10.jpg)

       ![](img/10.1.jpg)

       ![](img/10.2.jpg)

       ![](img/10.3.jpg)

   11. Then I lanch two client applications and send requests to the IWS the same time, the response will be returned asynchronously.

       ​
