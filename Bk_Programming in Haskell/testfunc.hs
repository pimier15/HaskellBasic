Ndouble x = x*x
ddouble x = double(double x)
dddouble x = double(double(double x))
fddouble x = double(double(double x))

factorial n = product[1..n]
average ns = sum ns `div` length ns
aaverage ns = sum ns `div` length ns+2

-- Test
a = b + c
  where
    b = 1
    c = 2
d = a * 2

{- double x = x * x * x -}
