# tone-analyzer-test #

This is a simple C# Windows forms app that calls IBM's Tone Analyzer service. 

## Prerequisites ##
To run the app, you need:

- Visual Studio - You can download VS 2015 Community Edition for free from the [downloads page](https://www.visualstudio.com/downloads/download-visual-studio-vs).
- An instance of the Tone Analyzer service and the service credentials. You’ll need to create an instance of the Tone Analyzer service on Bluemix, which is IBM’s cloud platform. It’s a pretty straightforward process, and you get a 30-day trial to test it out. Just follow the first steps in my previous blog [post](http://www.techmediapress.com/2016/03/calling-tone-analyzer-service-using.html) under the **Create the Service & Credentials** section.

 
## How it Works ##

After you get the app running, just enter the text you want to analyze and click the **Analyze** button. The code calls the service, returns the analysis results in JSON, and displays the results in three charts. Those charts correspond to the three categories of analysis that the service does: emotion, writing/language, and social. 
