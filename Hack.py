import os
from random import randint

# Loop through 1 to 364 (inclusive) for days
for i in range(1, 365):
    # Randomly select the number of commits for each day
    for j in range(0, randint(1, 10)):
        # Generate the date string for the commit
        d = str(i) + ' days ago'
        
        # Open the file to append the commit information
        with open('/home/syndicate/Music/LeetCode-Solution/hack.lua', 'a') as file:
            file.write(d)  # Write the date
        
        # Stage changes to Git
        os.system('git add .')
        
        # Commit with the specified date and a generic message
        os.system('git commit --date="' + d + '" -m "commit"')

# Push the changes to the remote repository
os.system('git push -u origin main')
