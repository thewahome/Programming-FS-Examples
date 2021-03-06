﻿namespace MyTests.Tests

open NUnit.Framework
open FsUnit
open System



[<TestFixture>]
type ``Test From Ch1`` () =
    let ex = new Ch1Examples()
    let hardDriveSize = 250I * 1024I * 1024I * 1024I
     
    [<Test>] member test.
     ``01 Basic`` () =
        Int32.Parse "1" |> should equal 1

    [<Test>] member test.
     ``02 Basic test`` () =
        ex.Calc 2 |> should equal 3

    [<Test>] member test.
     ``03 Truth table boolean values`` () =
        ex.PrintTruthTable (&&) 

    [<Test>] member test.
     ``04 Zettabyte`` () =
        ex.Zettabyte.ToString() |> should equal "1180591620717411303424"

    [<Test>] member test.
     ``05 bytesToGB`` () =
        ex.bytesToGB hardDriveSize |> should equal 250I

     [<Test>] member test.
     ``06 numbersNear - list comprehension`` () =
        ex.numbersNear 3 |> should equal [2;3;4]

     [<Test>] member test.
     ``07 more complex list comprehension`` () =
        ex.moreComplexListComprehension |> should equal [1;-2;3;-4;5;-6;7;-8;9;-10]

     [<Test>] member test.
     ``08 generate first ten multiples of a number list comprehension`` () =
         ex.multiplesOf 2 |> should equal [2;4;6;8;10;12;14;16;18;20]
     
     [<Test>] member test.
     ``09 generate first ten multiples of a number list comprehension simplified`` () =
         ex.multiplesOf2 3 |> should equal [3;6;9;12;15;18;21;24;27;30]

    [<Test>] member test.
     ``10 generate primes under 30`` () =
        ex.primesUnder 30 |> should equal [2;3;5;7;11;13;17;19;23;29]

    [<Test>] member test.
     ``11 List partition - multiples of 5 from 1 to 15`` () =
        ex.ListPartitionMultiplesOf5 |> should equal ([5;10;15], [1;2;3;4;6;7;8;9;11;12;13;14])

     [<Test>] member test.
     ``12 List aggregate - List fold count vowels (As, Es, Is, Os, Us)`` () =
        ex.countVowels "The rain in spain falls mainly on the plain for you" 
            |> should equal (5,2,5,3,1)

     [<Test>] member test.
     ``13 Option values - All positives`` () =
        ex.OptionNegativeNumbers [1;2;3] |> should equal None

      [<Test>] member test.
      ``14 Option values - With negatives`` () =
        ex.OptionNegativeNumbers [-3;1;-4;2;3]  |> should equal (Some [-3;-4] )





        