# docs/internals/contributing/committing-code

- Subject: docs/internals/contributing/committing-code (id `4cc316ed-1140-4f9e-9942-8647272ec5f1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 21 of 93
- Conflicts: 0
- Gaps: 0

## Facts

- Fixed #18307 -- Added git workflow guidelines. [ad83b0ab]
- Refactored the Django's documentation to remove mentions of SVN specific tasks. Added guidelines of how to use Git, GitHub, and how to use pull request together with Trac instead. [732e8968]
- Thanks to Full Name for the report, and to Reviewer for reviews. [4be6014e]
- #!/bin/sh exec python scripts/prepare_commit_msg.py "$@" [29107661]
- $ # Pull in the latest changes from main. $ git checkout main $ git pull upstream main $ # Rebase the pull request on main. $ git checkout pr/#### $ git rebase main $ git checkout main $ # Merge the work as "fast-forward" to main to avoid a merge commit. $ # (in practice, you can omit "--ff-only" since you just rebased) $ git merge --ff-only pr/XXXX $ # If you're not sure if you did things correctly, check that only the $ # changes you expect will be pushed to upstream. $ git push --dry-run upstream main $ # Push! $ git push upstream main $ # Delete the pull request branch. $ git branch -d pr/xxxx [d412b2fe]
- Backport of 80c0cbf1c97047daed2c5b41b296bbc56fe1d7e3 from main. [84e5ae01]
- Note that the Trac integration doesn't know anything about pull requests. So if you try to close a pull request with the phrase "closes #400" in your commit message, GitHub will close the pull request, but the Trac plugin will not close the same numbered ticket in Trac. [96f9aa86]
- Regression in 6ecccad711b52f9273b1acb07a57d3f806e93928. [f232417d]
- [1.3.x] Fixed #17028 -- Changed diveintopython.org -> diveintopython.net. [76f56a44]
- [alias] pr = !sh -c \"git fetch upstream pull/${1}/head:pr/${1} && git checkout pr/${1}\" [734d9176]
- bash scripts/backport.sh <sha> [2bb81421]
- git cherry-pick <sha> git commit --amend [77f9b8c6]
- * Correct: "Fixed Unicode bug in RSS API." * Incorrect: "Fixes Unicode bug in RSS API." (present tense) * Incorrect: "Fixing Unicode bug in RSS API." ("-ing" form) * Incorrect: "Fixed Unicode bug in RSS API" (missing trailing period) [bc7d382c]
- .. _Co-Authored-By: https://docs.github.com/en/pull-requests/committing-changes-to-your-project/creating-and-editing-commits/creating-a-commit-with-multiple-authors [26b5faa3]
- .. code-block:: none [591022f6b117516e-3]
- Credit the contributors in the commit message: "Thanks A for the report and B for review." Use git's `Co-Authored-By`_ as appropriate, including anyone whose earlier work the change builds on. [cac06336]
- For example: [bc295f9831206ba3]
- For the curious, we're using a `Trac plugin`_ for this. [32534a44]
- If you bring something up and nobody responds, please don't take that to mean your idea is great and should be implemented immediately because nobody contested it. Everyone doesn't always have a lot of time to read discussions immediately, so you may have to wait a couple of days before getting a response. [880a6f73]
- * A prefix ``[A.B.x]`` on the subject line, where ``A.B.x`` is the name of the ``stable/A.B.x`` branch being targeted. [0745e9c6]
- .. _backports: [ea638b66]

## Beyond the budget

72 more facts did not fit in the budget: [2af5560c] [23167377] [3ac826c2] [0d55c03d] [2caa4106] [8195c98c] [a1b44455] [6ba380f1] [2a9e6f8b] [53ec741b] [231f9470] [caa8d45a] [2035128d] [f8560efc] [cd4fec9a] [094b8084] [0a950b32] [24623163] [abf7a992] [cf084a8e] [5f177cb6] [ba01f7c7] [ff4ed8fb] [85b91be5] [4490df0b] [83a9a773] [e7a76e68] [216515fb] [64b8dec1] [33cfc83c] [b34f7795] [ae459631] [ab16e0aa61fdec9d-3] [591022f6b117516e-4] [591022f6b117516e-5] [7d9b70c5] [8aa7203c166b13be-21] [8aa7203c166b13be-22] [7714e199aac2701e-6] [942ae6c11625c81c-12] [e7a510c0] [654ead81] [f4b52b94] [38f3a454] [b79f1958] [e0dd1b4f] [f808a7e9] [ac704ef2] [5bc6e869] [bc295f9831206ba3-2] [570bf117] [97a8a398] [24606ca0] [3b1dceb4] [0faeb68a] [cbb28c3a] [bea4baec] [7efa9637] [05702e3e] [fe442c97] [11862bfd] [eeba95d1] [87992cfb] [1d75a1c9] [782580ef] [1d52e98d] [85be23d3] [90de6130] [0ef1b1fc] [6892ca81] [fcdc8428] [7fc8a123]
