class List:
    def __init__(self, myList):
        self.myList = myList
    
    def remove(self, to_remove, remove_duplicates='no'):
        output = []
        if isinstance(to_remove, list):
            pass

        else:
            for i in self.myList:
                output.append(i)
            
            if remove_duplicates == 'yes':
                for i in range(output.count(to_remove)):
                    output.remove(to_remove)
            
            remove_index = []
            for i in range(len(self.myList)):
                if self.myList[i] == to_remove:
                    remove_index.append(i)
        
        del output[max(remove_index)]
        return output
    
    def duplicates(self):
        i = 0
        dupl = []
        newList = [i for i in self.myList]

        while(i < len(newList)):
            if newList.count(newList[i]) > 1:
                dupl.append(newList[i])
            for j in dupl:
                if j in newList:
                    break
            i += 1
        return dupl

c = [1, 2, 1, 3, 5, 4, 5]
myList = List(c)
d = myList.remove(1)
dupl = myList.duplicates()
print(f'Original list: {c}')
print(f'New list: {d}')
print(f'Duplicate values: {dupl}')
