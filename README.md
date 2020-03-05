# NumbersToWords

#### NumbersToWords Game 03.05.2020\_

#### By _**Tiffany Siu and Andrew Philpott**_

## Description

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

- _Spec: For every three places in a number the first digit number will be it's word equivalent followed by hundred. If the second digit is 2 or greater, the words following after hundred will be number as word + "ty" format. The third digit will be it's word equivalent._

  - Input: "526"
  - Output: "Five hundred twenty six"

- _Spec: For every three places in a number the first digit number will be it's word equivalent followed by hundred. If the second digit is 2 or greater, the words following after hundred will be number as word + "ty" format. The third digit will be it's word equivalent._

  - Input: "526"
  - Output: "Five hundred twenty six"

## Setup/Installation Requirements

- Clone this repository.
- \$dotnet restore in tests
- \$dotnet build in main project folder

## Known Bugs

- No known bugs

## Support and contact details

- Issues or concerns? Contact us at andrewphilpott92@gmail.com

## Technologies Used

- C#
- .NET Core 2.2

### License

Copyright (c) 2020 **_Tiffany Siu and Andrew Philpott_**

_This software is licensed under the MIT license._
