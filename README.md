# NumbersToWords

#### NumbersToWords Game 03.05.2020\_

#### By _**Tiffany Siu and Andrew Philpott**_

## Descripiton

An Epicodus project for

## Summary

Tried our hands at the factory pattern and using abstract classes with interfaces and recursion. The project could have been done a number of different ways that we're more familiar with, but decided to struggle through and try to learn new concepts.

## Specs

- _Spec: If the user enters a non number then the application will respond with an error._

  - Input: "Hello"
  - Output: "Not a valid input. Please enter a number."

- _Spec: If the user enters a single digit number the application should return the number as a word between 1 and 9._

  - Input: "8"
  - Output: "Eight"

  - _Spec: If the user enters a number from 10-19, the application should return the number as a word in the teens._

  - Input: "14"
  - Output: "Fourteen"

- _Spec: If the user enters a number with 2 digits it should return a number as a word in the tens place._

  - Input: "60"
  - Output: "Sixty"

- _Spec: If the user enters any multiples of 100 the final 2 words of the string will be 1-9(converted to word equivalent) hundred._

  - Input: "900"
  - Output: "Nine hundred"

- _Spec: If the second place in a three places division is a zero and the third place isn't 0 the number words will follow the format first place number word followed by hundred followed by "and" followed by the third place word equivalent_

  - Input: "901"
  - Output: "Nine hundred and one"

- _Spec: For every three places in a number the first digit number will be it's word equivalent followed by hundred. If the second digit is 2 or greater, the words following after hundred will be number as word + "ty" format. The third digit will be it's word equivalent._

  - Input: "526"
  - Output: "Five hundred twenty six"

- _Spec: For every three places in a number the first digit number will be it's word equivalent followed by hundred. If the second digit is 1 and the third digit is 3 or more, the words following after hundred will be dicated by the third digit plus "teen"._

  - Input: "516"
  - Output: "Five hundred sixteen"

- _Spec: For every three places in a number starting after the fourth digit from the right, the digit number will also add its group name (thousand, million, billion, trillion)._

  - Input: "123456516"
  - Output: "One hundred twenty three million four hundred fifty six thousand five hundred sixteen"

## Setup/Installation Requirements

- Clone this repository.
- \$dotnet restore in tests
- \$dotnet build in main project folder

## Known Bugs

- The recursive loop for different digits in not getting the correct input at the moment and program crashes

## Support and contact details

- Issues or concerns? Contact us at andrewphilpott92@gmail.com or tsiu88@gmail.com

## Technologies Used

- C#
- .NET Core 2.2

### License

Copyright (c) 2020 **_Tiffany Siu and Andrew Philpott_**

_This software is licensed under the MIT license._
