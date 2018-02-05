lessThen :: Integer -> [Integer]
lessThen n = [ 0.. n-1]

plusMinus :: Integer -> Integer -> [Integer]
plusMinus a b = [a + b , a - b]

allPM0s :: Integer -> [Integer]
allPM0s n = concat ( map (plusMinus 0) (lessThen n) )

allPMs :: Integer -> Integer ->  [Integer]
allPMs m n = concat (   map   ( \x  ->  concat( map (plusMinus x) (lessThen n) ))  (lessThen m) )
