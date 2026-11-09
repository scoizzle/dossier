# docs/internals/contributing/writing-code/working-with-git

- Subject: docs/internals/contributing/writing-code/working-with-git (id `f2216a68-4d2d-49a0-82e5-7e9dfa1909eb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 31 of 116
- Conflicts: 0
- Gaps: 0

## Facts

- - Fixed whitespace errors in foobar. - Reworded the docstring of bar(). [d17fbbfa]
- Made changes asked in review by <reviewer>. [c8f7ecd5]
- cd django [ab6b10fb]
- git checkout -b pull_xxxxx upstream/main curl -L https://github.com/django/django/pull/xxxxx.patch | git am [684564e5]
- git checkout -b ticket_xxxxx upstream/main [53e8a44a]
- git checkout -b ticket_xxxxx_1_4 upstream/stable/1.4.x [bdb97bc7]
- git clone https://github.com/GitHub_nick/django.git [1d21f544]
- git commit [50407a5c]
- git commit --amend [3dcd56d8]
- git commit -m 'Added two more tests for edge cases.' [901a6c9b]
- git push --force-with-lease origin ticket_xxxxx [774c9596b7c4cca3]
- git push origin ticket_xxxxx [e93558b697b6630c]
- git rebase -i HEAD~2 [8f459a3da60d768b]
- git rebase -i HEAD~3 [5c048eec]
- git rebase -i HEAD~3 # Choose edit, pick, pick for the commits # Now you are able to rework the commit (use git add normally to add changes) # When finished, commit work with "--amend" and continue git commit --amend # Reword the commit message if needed git rebase --continue # The second and third commits should be applied. [a379f55e]
- git remote add akaariai https://github.com/akaariai/django.git [21f66c0a]
- git remote add upstream https://github.com/django/django.git git fetch upstream [541f351b]
- $ git config --global user.name "Your Real Name" $ git config --global user.email "you@email.com" [8f5ff4c4]
- git fetch upstream git rebase upstream/main [4006260a]
- * Work on GitHub if you can. * Announce your work on the Trac ticket by linking to your GitHub branch. * When you have something ready, make a pull request. * Make your pull requests as good as you can. * When doing fixes to your work, use ``git rebase -i`` to squash the commits. * When upstream has changed, do ``git fetch upstream; git rebase``. [5bcf565d]
- * commits with one logical change in each, following the :doc:`coding style </internals/contributing/writing-code/coding-style>`, [1a53fb02]
- * documentation and tests, if needed -- actually tests are always needed, except for documentation changes. [33cca5ea]
- * well-formed messages for each commit: a summary line and then paragraphs wrapped at 72 characters thereafter -- see the :ref:`committing guidelines <committing-guidelines>` for more details, [11fa9077]
- .. _Git: https://git-scm.com/ .. _Git repository: https://github.com/django/django/ .. _GitHub: https://github.com/ [331f5df7]
- .. _editing-commit-messages: [cd404655]
- .. code-block:: shell [8aa7203c166b13be-29]
- .. code-block:: shell [8aa7203c166b13be-30]
- .. code-block:: shell [8aa7203c166b13be-31]
- .. code-block:: shell [8aa7203c166b13be-32]
- .. code-block:: shell [8aa7203c166b13be-33]
- .. code-block:: shell [8aa7203c166b13be-34]

## Beyond the budget

82 more facts did not fit in the budget: [8aa7203c166b13be-35] [8aa7203c166b13be-36] [8aa7203c166b13be-37] [8aa7203c166b13be-38] [8aa7203c166b13be-39] [8aa7203c166b13be-40] [8aa7203c166b13be-41] [8aa7203c166b13be-42] [8aa7203c166b13be-43] [8aa7203c166b13be-44] [8aa7203c166b13be-45] [8aa7203c166b13be-46] [8aa7203c166b13be-47] [8aa7203c166b13be-48] [3a9340cd0d877339-5] [f1db0171] [87e490f8] [8d4ed5ca] [9ed60b61] [79f7de98] [2399830a] [d20fbd19] [2f8ed668] [675f651f] [6e2080b0] [188f496b] [e0e1a151] [d5cd262f] [cdabf4e3] [d9b6c789] [0fe16d52] [31c8a94d] [1c282a3a] [bda9cc95] [fd8e41ae] [795287323bc9e2a3] [3f9c6c9f] [21669715] [737f8d98] [9a6ec1ce] [229a5e85] [d576c147] [73c22133] [c47cdd12] [d4f4988e] [c54d7925] [b73fbdd6] [a204562d] [087eb78b] [3f1d52fa] [5ceceba5] [d1725def] [dfca28c4] [83c9fc39] [6ecc5891] [9ceabe04] [d96a4647] [a85db11f] [2271680e] [a050bd58] [df86e9d2] [d3c1882b] [292b93dc] [fcf9b92f] [2a4a2194] [bc851018] [d69e569d] [3fc7a901] [feec9e59] [9ac735fb] [33e17089] [cb95859f] [d6e3ff33] [c36beb1d] [ba4328ed] [546c6273] [13d474ec] [f1f30fb0] [8b5187ad] [15af31fb] [4e923b6c] [9c77d0ae]
