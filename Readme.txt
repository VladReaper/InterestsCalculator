
InterestsCalculator is an Windows Forms application.

Compiled executable you can find in InterestsCalculator\InterestsCalculator\bin\Release

Project is built under .NET Framework 4.7.2 and was written and tested using Visual Studio 2017.
No custom libraries had been used.


Main assumptions and decisions I did during design:

- as it's just a test that suppose to take 60 minutes I didn't pay attention to visual details;
- I decided to use ValueChanged event handler to evaluate interests instead of button click;
- I decided to have two separate projects one for core app and second for tests, which would be good approach for future extensions of the functionality;
- I prepared only one combined test that takes pairs of balance and expected interests, as this test is fairly simple and covers whole functionality;
- all UI testing was done manualy, such as: field validation and format of displayed results;
- interests band resolution is fairly simple so I decided to use simplest solution of bunch of ifs. I can imagine that in real life scenarion it would need to be done in seperate function using more complex stuctures.