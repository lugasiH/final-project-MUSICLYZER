import sys as s
#get the song from the C# code
 songName=s.argv[1]

#connect to matlab to run the main algorithm
import numpy as np
import h5py
f = h5py.File('code.m','r')
data = f.get('data/variable1')
data = np.array(data) # For converting to a NumPy array
print(data)



import abjad
note=abjad.Note("e'4")
abjad.show(note)