data Tree a = EmptyTree | Node a (Tree a) (Tree a ) deriving(Show)

data TrafficLight = Red | Yellow | Green

instance Eq TrafficLight where
  Red == Red = True
  Green == Green = True
  Yellow == Yellow = True
  _ == _ = False

instance Show TrafficLight where
  show Red = "Red L"
  show Yellow = "Yellow L"
  show Green = "Green L"

-- Yes No

class YesNo a where
  yesno :: a -> Bool

instance YesNo Int where
    yesno 0 =  False
    yesno _ = True

instance YesNo [a] where
  yesno [] = False
  yesno _ = True

instance YesNo (Maybe a) where
  yesno Nothing = False
  yesno _ = True

instance YesNo (Tree a ) where
  yesno EmptyTree = False
  yesno _ = True

instance YesNo ( TrafficLight ) where
  yesno Red = False
  yesno _ = True

yesnoIf :: (YesNo y) => y -> a -> a-> a
yesnoIf yesnoVal yesResult noResult =
  if yesno yesnoVal
    then yesResult
    else noResult
