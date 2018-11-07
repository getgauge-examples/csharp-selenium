Appveyor -
[![Build status](https://ci.appveyor.com/api/projects/status/3e4j7b0q9ix84r8u/branch/master?svg=true)](https://ci.appveyor.com/project/sguptatw/gauge-active-admin-example-csharp/branch/master)

# Gauge example in csharp

This is an example project for doing web automation testing with [Gauge](http://getgauge.io). This project tests some of the functionalities of the [active admin demo](https://github.com/getgauge/activeadmin-demo) app. This app is hosted as a Java WAR (with embedded Jetty).

## Running this example
The tests are run on Chrome by default.

### Prerequisites

This example requires the following softwares to run.
  * [Java 1.7](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html) or above
    * Note that this is required to run the active admin demo application
  * .NET v4.5 (required for the CSharp plugin to run), you could write your test code to target a lesser version.
  * Gauge Visual Studio plugin (2015)
  * [NuGet](https://www.nuget.org/) package manager
  * [Gauge](http://getgauge.io/get-started/index.html)
  * Gauge csharp plugin
    * can be installed using `gauge --install java`
  * Chrome

### Setting up the System Under Test (SUT)

* Download [activeadmin-demo.war](https://bintray.com/artifact/download/gauge/activeadmin-demo/activeadmin-demo.war)
* Bring up the SUT by executing the below command
```
java -jar activeadmin-demo.war
```
* The SUT should now be available at http://localhost:8080

## Get the Dependencies

NuGet.exe install

## Run specs

This runs Gauge specs with with IE as default browser for specs execution. Make sure IE is installed in your machine and [IEDriverSelenium](http://selenium-release.storage.googleapis.com/index.html) is in PATH.

If you want to use Firefox/Chrome as browser, pass the corresponding argument to set browser environment as follows:

```
gauge specs --env="firefox"
or
gauge specs --env="chrome"
```

## Topics covered in the example

* [Specification](http://getgauge.io/documentation/user/current/specifications/index.html), [Scenario](http://getgauge.io/documentation/user/current/specifications/scenarios.html),  [Step](http://getgauge.io/documentation/user/current/specifications/steps.html), [Concepts](http://getgauge.io/documentation/user/current/specifications/concepts.html) and [Context Steps](http://getgauge.io/documentation/user/current/specifications/contexts.html)
* [Table parameters](http://getgauge.io/documentation/user/current/specifications/parameters.html#table-parameter)
* Using [External datasource (special param)](http://getgauge.io/documentation/user/current/specifications/parameters.html#special-parameters)
* Using [tags](http://getgauge.io/documentation/user/current/specifications/tags.html)
* Using Gauge with [Selenium Webdriver](http://docs.seleniumhq.org/projects/webdriver/)
* Running Gauge specs with [Maven](https://maven.apache.org/)

# Copyright
Copyright 2016, ThoughtWorks Inc.
