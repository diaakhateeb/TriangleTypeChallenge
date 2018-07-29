# Triangle Type Challenge

The solution objective is to find type of triangle according to the lengths of its sides.

## Description

<strong>Triangle can be classified as below:</strong>

- <strong>An equilateral triangle</strong> has all sides the same length. An equilateral triangle is also a regular polygon with all angles measuring 60°.
- <strong>An isosceles triangle</strong> has two sides of equal length. An isosceles triangle also has two angles of the same measure, namely the angles opposite to the two sides of the same length; this fact is the content of the isosceles triangle theorem.
- <strong>A scalene triangle</strong> has all its sides of different lengths. Equivalently, it has all angles of different measure.

## Solution Hierarchy:

 ### 1. Triangle Main:
It has the core functionality of the solution where all processing gets placed. It contains three layers: Core, Cross and Model layers. Core layer is the heart of the processing where it has Factory and Repository interfaces in addition to Triangle Enumeration.

**1.1. Core Layer:**

 - The **[ITriangleFactory](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeLibrary/Core/Interfaces/Factory/ITriangleFactory.cs)**  interface is responsible for safely instantiating repository object using IoC Unity container in respect to Dependency Injection SOLID principle. It has **GetInstance** method that returns Generic type (T) that is identified by the caller.
 - The **[ITriangleRepository](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeLibrary/Core/Interfaces/Repository/ITriangleRepository.cs)**  interface is the gateway to the outer world as it responsible for bringing client parameters to the core layer and brings the result back to the client (caller). It has **GetTriangleType** and **ValidateTriangleValues** methods in addition to **TriangleEntity** property.
   - **GetTriangleType** method calls **FindTriangle** method of **TriangleEntity** class to check against passed parameters and returns **TriangleType** Enum value. Triangle Type can be Equilateral, Isosceles, Scalene or Unknown.
   - **ValidateTriangleValues** method is responsible for applying the core checks against the passed triangle values and returns result in string object that is empty if no errors or has an error message if any of the checks failed.
   - **TriangleEntity** property is the gateway to initialize the Length, Height and Base Triangle core properties.
 - **[TriangleTypeEnum](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeLibrary/Core/Enums/TriangleTypeEnum.cs)** is the enumeration type which contains triangle type list (Equilateral, Isosceles, Scalene and Unknown).

**1.2 Cross Layer:**
It has helper classes that are used across the solution boundary.

 - Validation interfaces and classes that are used to validate passed Triangle values.
 - **[INumericValidation](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeLibrary/Cross/Helpers/Validation/Interfaces/INumericValidation.cs)** interface that provides method **GreaterThanZero** to check if triangle values are not equal to zero or negative.
 - **[ITriangleAxisesValidation](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeLibrary/Cross/Helpers/Validation/Interfaces/ITriangleAxisesValidation.cs)** interface that exposes **AxisesValidForTriangle** method to check if the passed values are valid values for a triangle (*if two sides summation are greater than the third side*).

**1.3 Model Layer:**
It exposes the solution entities such as Triangle Entity.
 - **[IEntity](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeLibrary/Model/Interfaces/IEntity.cs)** interface that provides the core function of finding triangle type **FindTriangle** and the main triangle three properties **Length**, **Height** and **Base**.

 ### 2. Triangle Client:
 It is the consumer or caller application that performs the following sequence to get the triangle type:
 

 - Use Factory class of the Core layer to get safe object of repository class through calling **GetInstance** method. `ITriangleRepository _triangle = new TriangleFactory<TriangleRepository>().GetInstance();`
 - Set **TriangleEntity** property triangle axises values 
`_triangle.TriangleEntity = new TriangleEntity
                {
                    Length = double.Parse(TextBoxTriangleWidth.Text),
                    Height = double.Parse(TextBoxTriangleHeight.Text),
                    Base = double.Parse(TextBoxTriangleBase.Text)
                };`
- Call **ValidateTriangleValues** to validate passed values.
- If no errors returned, call **GetTriangleType** main function that returns triangle type Enum value.

### 3. Unit Testing:
It has two classes **[UnitTestInputValidation](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeChallengeUnitTest/UnitTestInputValidation.cs)** and **[UnitTestGetTriangleType](https://github.com/diaakhateeb/TriangleTypeChallenge/blob/master/TriangleTypeChallengeUnitTest/UnitTestGetTriangleType.cs)**.
- **UnitTestGetTriangleType**: Has four unit tests for checking triangle types  **TestMethod_Get_Triangle_Type_Equilateral**, **TestMethod_Get_Triangle_Type_Equilateral_Against_Isosceles**, **TestMethod_Get_Triangle_Type_Equilateral_Against_Scalene**, **TestMethod_Get_Triangle_Type_Isosceles_Against_Scalene** and  **TestMethod_Get_Triangle_Type_Scalene**.
- **UnitTestInputValidation**: Has four unit tests for passed triangle values **TestMethod_Validate_Axises_Values_When_Grater_Than_Zero**, **TestMethod_Validate_Axises_Values_When_Less_Than_Zero**, **TestMethod_Validate_Axises_Against_Unknown_Triangle_Type** and **TestMethod_Invalidate_Axises_Against_Unknown_Triangle_Type**.

## Technical Design Highlights
As a simple solution, it applies one SOLID principle and two design patterns.
- **Dependency Inversion Principle**: DI principle aims to decouple the high level components implementation from the low level ones and both should depends on abstraction (Interfaces). The solution here applies such principle using Microsoft Unity container IoC (Inversion of Control), and It is used through the Factory pattern class to instantiate Repository pattern class object. It injects validations objects parameters through the constructor.
- **Factory Pattern**: It is one of the creational patterns that aims to create class object without having to specify the exact class of the object that will be created. It is common pattern and widely used nowadays as it fits all software applications sizes. The solution applies it in conjunction with the IoC Unity to create Repository class object.
- **Repository Pattern**: It is widely used in the DDD, and it builds an interface between the core components and outer world. It decouples the business layer from the front layer such as providing database model functions to the business layer. This gives us the liberality to change database or the model as a whole with no need to change the business layer implementation. The solution applies it to expose the validation, get triangle type methods and triangle entity property.
