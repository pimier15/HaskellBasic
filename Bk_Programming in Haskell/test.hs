double x = x*x
ddouble x = double (double x)

-- Function Basic 4.1--
isDigit :: Char ->Bool
isDigit x = x>='0' && x<='9'

even :: Integral a => a -> Bool
even n = n `mod` 2 == 0

splitAt :: Int -> [a] -> ([a],[a])
splitAt n xs = (take n xs , drop n xs)

recip :: Fractional a => a -> a
recip n = 1/ n

-- Conditional Function 4.2 --
abs :: Integer -> Integer
abs x = if n >= 0 then n else n*-1

signum :: Int -> Int
signum n = if n < 0 then -1 else
		   if n == 0 then 0 else 1
		   
		  
-- Guarded Equation 4.3 --
gabs n | n >0 =n
	   | otherwise = -n
	   
-- Pattern Matching 4.4 --
not' :: Bool -> Bool
not' False = True
not' True = Flase

(&&&) :: Bool -> Bool -> Bool
True &&& b = b
false &&& _ = False

fst :: (a,b) -> a
fst(x,_) = x

-- Element of list or tuple is check --
snd :: (a,b) -> b
snd(_,y) = y

test ::[Char] -> Bool
test['a',_,_] = True
test _ = False

testwithcons :: [Char] -> Bool
testwithcons ('a':_) = True
testwithcons _ = False

null :: [a] -> Bool
null [] = True
null (_:_) = False

head ::[a] -> a
head (x:_) = x

tail ::[a] ->a
tail (_:xs) = xs

--Int Pattern --
pred :: Int -> Int
pred 0 = 0
pred n = n - 1









