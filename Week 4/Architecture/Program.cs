using System;

class Program
{//---Start of Class Program---
    static void Main(string[] args)
    {//---Start of Main Method---
       //Application Architectural Design Structures and Patterns
        //Why use Design Patters / Standard Conventions?
            //Reusability
            //Readability
            //Scalability
            //Modulatirty
            //Maintainability
        //To help us structure our application we are going to organize our applications into Layers
            //Layers -> Roles/Duties that our application needs to accomplish
            //Single Responsibility Principle -> each aspect of our application should have but one responsibility AND should be only aspect that manages said responsibility
        //Layers of an Applicaiton (workds bottom up)
            //Application Layer
                //Developing an interface for the end user to use the presented information from the layer below
                    //GUI -> Graphical User Interface
            //Presentation Layer
                //Converts data into a presentable format
            //Controller Layer
                //Responsible for handling Application Logic, which includes ideas like processing requests and generating responses
            //Service Layer
                //Responsible for performing Business Logic, which includes things like filtering serach, sorting, validating, etc
                    //Would do so upon the data layer retreived by the Repository Layer
            //Data Access Layer (Repository Layer)
                //Responsible for data(base) interaction
                //These objects we create will perform any amount of retreival, manipulation, destruction to our data
                    //These Objects are referred to as Data Access Objects: DOAs
            //Data Layer - Where all of our data exists (typically stored in something like a database of file system)
                //Represented in your Applications through: Models (Ex: any Class that we create that should Model our data (i.e. Cars, Users, etc.))
    }//---End of Main Method---
}//---End of Class Program---

