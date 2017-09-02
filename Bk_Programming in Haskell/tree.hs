data Tree a = EmptyTree | Node a (Tree a) (Tree a ) deriving(Show)

singleton :: a -> Tree a
singleton x = Node x EmptyTree EmptyTree

treeInsert :: (Ord a) => a -> Tree a ->  Tree a
treeInsert  x EmptyTree = singleton x
treeInsert x (Node a left right)
  |x == a = Node x left right
  |x < a = Node a (treeInsert x left) right
  |x > a = Node a left (treeInsert x right)

-- First Element is to be Root node
treeInsert2 :: (Ord a) => Tree a -> a ->  Tree a
treeInsert2 EmptyTree x  = singleton x
treeInsert2 (Node a left right) x
  |x == a = Node x left right
  |x < a = Node a (treeInsert2 left x ) right
  |x > a = Node a left (treeInsert2 right x )

-- First Elemtn is stack to next. this is not good. please make exzmple yourself
treeInsert3 :: (Ord a) => Tree a -> a ->  Tree a
treeInsert3 EmptyTree x  = singleton x
treeInsert3 (Node a left right) x
  |x == a = Node x left right
  |x < a = Node a (treeInsert2 left x ) right
  |x > a = Node a left (treeInsert2 right x )

treeElem :: (Ord a ) => a -> Tree a ->Bool
treeElem x EmptyTree = False
treeElem x (Node a left right)
  | x == a = True
  | x < a = treeElem x left
  | x > a = treeElem x right


nums =  [1,6,2,7,6,4,11]
numTree = foldr treeInsert EmptyTree nums
numTree2 = foldl treeInsert2 EmptyTree nums
