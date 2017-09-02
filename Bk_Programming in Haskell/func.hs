-- lambda function --
odd' :: Int -> [Int]
odd' n = map f [0..n-1]
          where f x = 2*x + 1

odd'' :: Int -> [Int]
odd'' n = map (\x -> 2*x + 1) [0..n-1]

-- Section --

mul3 :: Int -> Int -> Int -> Int
mul3 = \x -> ( \y -> (\z -> x * y * z ))
