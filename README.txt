VSTEST.CONSOLE
==============

c:\Users\magnusl\source\repos\UnitTestExamplesMsTest>OpenCover.Console.exe -target:vstest.console.exe -targetargs:"C:\Users\magnusl\source\repos\UnitTestExamplesMsTest\UnitTestExamplesMsTest\bin\Debug\UnitTestExamplesMsTest.dll" -register:user -output:coverage.xml -filter:"+[ClassLibraryToTest*]*
Executing: C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe
Microsoft (R) Test Execution Command Line Tool Version 15.8.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
Passed   TestAddTwoPositiveNumbers
Failed   TestAddTwoNegativeNumbers
Error Message:
 Assert.AreEqual failed. Expected:<-118>. Actual:<-8>.
Stack Trace:
   at UnitTestExamplesMsTest.UnitTest1.TestAddTwoNegativeNumbers() in C:\Users\magnusl\source\repos\UnitTestExamplesMsTest\UnitTestExamplesMsTest\UnitTest1.cs:line 30


Total tests: 2. Passed: 1. Failed: 1. Skipped: 0.
Test Run Failed.
Test execution time: 0,7809 Seconds
Committing...
Visited Classes 1 of 1 (100)
Visited Methods 1 of 1 (100)
Visited Points 5 of 7 (71.43)
Visited Branches 2 of 3 (66.67)

==== Alternative Results (includes all methods including those without corresponding source) ====
Alternative Visited Classes 1 of 1 (100)
Alternative Visited Methods 2 of 2 (100)

c:\Users\magnusl\source\repos\UnitTestExamplesMsTest>reportgenerator -reports:coverage.xml -targetdir:coverage
Loading report 'c:\Users\magnusl\source\repos\UnitTestExamplesMsTest\coverage.xml'
 Preprocessing report
 Initiating parser for OpenCover
  Current Assembly: ClassLibraryToTest
Initializing report builders for report types: Html
Analyzing 1 classes
 Creating report 1/1 (Assembly: ClassLibraryToTest, Class: ClassLibraryToTest.ClassToTest1)
 Creating summary
Report generation took 0,3 seconds

c:\Users\magnusl\source\repos\UnitTestExamplesMsTest>




NUNIT
=====

c:\Users\magnusl\source\repos\UnitTestExamplesMsTest>OpenCover.Console.exe -target:nunit3-console.exe -targetargs:C:\Users\magnusl\source\repos\UnitTestExamplesMsTest\UnitTestExamplesNUnit\bin\Debug\UnitTestExamplesNUnit.dll -register:user -output:coverage.xml -filter:"+[ClassLibraryToTest*]*
c:\Users\magnusl\source\repos\UnitTestExamplesMsTest>reportgenerator -reports:coverage.xml -targetdir:coverage
