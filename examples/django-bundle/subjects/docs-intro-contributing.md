# docs/intro/contributing

- Subject: docs/intro/contributing (id `85a19f7e-8cc6-4751-9b4a-e0090a5544c9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 30 of 170
- Conflicts: 0
- Gaps: 0

## Facts

- # Finally, fall back and assume it's a URL return to + + +def make_toast(): + return 'toast' diff --git a/docs/releases/6.2.txt b/docs/releases/6.2.txt index 7d85d30c4a..81518187b3 100644 --- a/docs/releases/6.2.txt +++ b/docs/releases/6.2.txt @@ -34,6 +34,11 @@ Minor features -------------- [3c34c7d6]
- ...\> %HOMEPATH%\.virtualenvs\djangodev\Scripts\activate.bat [b56619a4]
- $ . ~/.virtualenvs/djangodev/bin/activate [3def73f9]
- $ ./runtests.py [543acb37e7ac42ca]
- $ ./runtests.py [543acb37e7ac42ca-2]
- $ ./runtests.py shortcuts [27f0a806af4f4fa4]
- $ ./runtests.py shortcuts [27f0a806af4f4fa4-2]
- $ git add --all [8ed3a5fc]
- $ git checkout -b ticket_99999 [5abf19f8]
- $ git clone https://github.com/YourGitHubName/django.git [ec86ad5f]
- $ git commit [95d040be]
- $ git diff --cached [b125cc10]
- $ git push origin ticket_99999 [c7d2569a]
- $ python -m pip install -e /path/to/your/local/clone/django/ [07a29e7d]
- $ python -m pip install -r requirements/py3.txt [baf0a8d0]
- $ python3 -m venv ~/.virtualenvs/djangodev [bc143184]
- $ source ~/.virtualenvs/djangodev/bin/activate [b55d1ad1]
- * A good first look at writing tests for Django can be found in the documentation on :doc:`/topics/testing/overview`. * Dive Into Python (a free online book for beginning Python developers) includes a great `introduction to Unit Testing`__. * After reading those, if you want something a little meatier to sink your teeth into, there's always the Python :mod:`unittest` documentation. [82d4e983]
- * The new :func:`django.shortcuts.make_toast` function returns ``'toast'``. [a47c2100]
- +:mod:`django.shortcuts` +~~~~~~~~~~~~~~~~~~~~~~~ + +* The new :func:`django.shortcuts.make_toast` function returns ``'toast'``. + :mod:`django.contrib.admin` ~~~~~~~~~~~~~~~~~~~~~~~~~~~ [7a2b97ca]
- .. code-block:: doscon [423631a5927aaff7-10]
- .. function:: make_toast() [7145c6b9]
- .. versionadded:: 6.2 [17b3c013]
- :mod:`django.shortcuts` ~~~~~~~~~~~~~~~~~~~~~~~ [a74aee86]
- Django should provide a function ``django.shortcuts.make_toast()`` that returns ``'toast'``. [ab56cd94]
- Fixed #99999 -- Added a shortcut function to make toast. [fde21776]
- For this tutorial and the ticket we're working on, testing against SQLite is sufficient, however, it's possible (and sometimes necessary) to :ref:`run the tests using a different database <running-unit-tests-settings>`. When making UI changes, you will need to :ref:`run the Selenium tests <running-selenium-tests>`. [7ec25100]
- If you are looking for a reference on the details of making code contributions, see the :doc:`/internals/contributing/writing-code/index` documentation. [d2178d675b9bdfd7-2]
- ImportError: cannot import name 'make_toast' from 'django.shortcuts' [75189045]
- .. console:: [7714e199aac2701e-52]

## Beyond the budget

139 more facts did not fit in the budget: [b51fe4b8] [89e776fa] [fe96e6a6] [9886d24e] [6c744a5b] [fae69b92] [3085bc47] [264f52b5] [5cf39a47] [ce581af1] [86ac1093] [db046982] [05b39be9] [957878c4] [fe532420] [28f76d0c] [79fee087] [2d9866bfadae9fc2] [10f252c6] [7b76700c] [dbb2ef17dd903b2b] [faf6f5a8efbd7831-10] [faf6f5a8efbd7831-11] [13c8b0f1] [fccd37de02dbdecc-3] [3871ddb3eff15a0e-19] [3871ddb3eff15a0e-20] [3a9340cd0d877339-8] [7714e199aac2701e-53] [7714e199aac2701e-54] [7714e199aac2701e-55] [7714e199aac2701e-56] [7714e199aac2701e-57] [7714e199aac2701e-58] [7714e199aac2701e-59] [7714e199aac2701e-60] [7714e199aac2701e-61] [7714e199aac2701e-62] [7714e199aac2701e-63] [7714e199aac2701e-64] [942ae6c11625c81c-19] [6b4a5e54e001d097-12] [c344bcc8] [b67186fd] [52de5f08] [82b09c52] [ccf8d6de] [5729f4cd] [e98c7f79] [d023719e] [25b0832d] [ca1ae645] [86e0112d] [a15410fa] [78a25c28] [b442d661] [93eb0fb1] [b22cacbf] [0b567d10] [bb2f2331] [12603d7a] [9f9fa42f] [eb33ede4] [54efb7e2] [ddfbfcac] [0bd91342] [704e0b30] [330435eb] [138c1c92] [c86efd61b4d2ef12-2] [96649b11] [1d0cb9eb] [4bc5cd74] [f5fe5c2a] [795287323bc9e2a3-2] [1f18460e] [2edcdce89eec848d-2] [e68baf5b] [9a6f67c0] [e0a5d525] [02b54e26] [88065c06] [6ea0b126] [41c8e069] [a12a24a3] [26156f79] [c7f3b09e] [b375a206] [a99db716] [c8449e5a] [2e1f030d] [8f5e6caf] [f4677f35] [f88f7eb5] [385b1ba9] [fc5a797e] [2c32e019] [844616c0] [87b70258] [38360c51] [66db7c43] [11f38224] [283e1c1b] [d8c75bdd] [2394612c] [9163a53f] [1bb94960] [2cccc903] [9d68ecd7] [409e2a95] [b90a25f8] [6ad6fdec] [12f005ad] [6adbe4b3] [6d6e2efe] [28cd4a14] [32413c28] [cab2aa20] [1afb3a8e] [1c20c8ec] [4b6f7fd2] [0ba5cd95] [aacc2321] [ce91b04a] [bbdbf489] [d421a1bf] [39241187] [14a29374] [5317f239] [d869c082] [810d541b] [f0dc9cdd] [e032bfa7] [11ec72c2] [3f79c521] [3913fe75] [8f2cdeb4fca1bdd2-2] [feb0bd11] [10b2fe62]
