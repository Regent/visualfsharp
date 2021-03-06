// #Regression #NoMono #CodeGen #Optimizations #ReqNOMT   
// Regression test for FSHARP1.0:3990
module EqualsMicroPerfAndCodeGenerationTests = 
    type Key = Key of int * int
    let f5() = 
       let mutable x = false
       let t1 = Key(1,2)
       let t2 = Key(1,3)
       for i = 0 to 10000000 do
           x <- (t1 = t2)
       x
