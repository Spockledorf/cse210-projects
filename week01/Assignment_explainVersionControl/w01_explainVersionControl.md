W01 Assignment: Explain Version Control
Overview
Articulate the principle of version control.

Instructions
Now that you have learned about the principle of version control and practiced using Git and GitHub, answer the following question (the way you would in a job interview):

What is version control and why is it important?

Your response must:
Explain the meaning of Version Control
Highlight a benefit of Version Control
Example of version control: Describe the way version control might be used on a software development team.
Show a command used in Version Control (for example a Git command)
Thoroughly explain these concepts (this likely cannot be done in less than 100 words)

Version Control (or a VCS, version control system) is the means by which developers track changes they and their team make to code. When a developer uses a form of version control, they know what changes were made, when changes were made, who made those specific changes, and why the changes were made.
Version control becomes all the more important when more than one person is working on the same code. One benefit of using a VCS is the ability of a developer to find their code that worked and compare it with other versions of their code to troubleshoot bugs. Another benefit is the ability to track what changes, fixes, or improvements you or others make to specific branches of code. 
For example, John Bremley is a developer who is contributing to a repository. He had found the source of a bug that was reported. John used `git pull` to retrieve any changes his team had made since he last synced. After ensuring he had updated code, he created a bugfix branch with `git checkout -b fix/EFG23A` so his changes would stay isolated from the main branch. John then removed the bad logic that had generated the issue, replaced it with code that fixed the bug, and allowed for more error catching. Once he had made the changes on his machine, John still had to push the fix to the repository. He used `git add lotteryLogic.cs` to stage the file that had the fix for the bug. He did NOT use the command `git add .` as he was still working on another file and didn't want to push all his updates yet. John then wrote a quick summary of his commit with `git commit -m "Fixed bug ID: EFG23A, added integer error checking."` To push his staged changes to the repository, John finally used `git push origin fix/EFG23A` to get his changes into the repository.