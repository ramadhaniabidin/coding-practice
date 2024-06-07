grid = [
    [3,1,2,2],
    [1,4,4,5],
    [2,4,2,2],
    [2,4,2,2]
]
class MySolution:
    def __init__(self) -> None:
        pass

    def transpose(self, grid):
        cols = []
        for i in range(len(grid)):
            col = []
            for j in range(len(grid)):
                col.append(grid[j][i])
            cols.append(col)
        return cols
    
    def equalPairs(self, grid):
        cols = self.transpose(grid)
        pair_count = 0
        for row in grid:
            for col in cols:
                pair_count += 1 if row == col else 0
        return pair_count
    
class ChatGPTSolution:
    def __init__(self) -> None:
        pass

    def transpose(self, grid):
        # * (asterisk) is to unpack the list inside of a list
        # so it became zip( [3,1,2,2], [1,4,4,5], [2,4,2,2], [2,4,2,2] )
        # The zip function takes these rows and groups the elements based on their positions:
        return [list(col) for col in zip(*grid)]
    
    def equalPairs(self, grid):
        cols = self.transpose(grid)
        pair_count = sum(1 for row in grid for col in cols if row == col)
        return pair_count
    
myObj = MySolution()
cheat = ChatGPTSolution()

print(f'Number of equal row and column pair of {grid} according to my solution is : {myObj.equalPairs(grid)}')
print(f'Number of equal row and column pair of {grid} according to ChatGPT solution is : {cheat.equalPairs(grid)}')