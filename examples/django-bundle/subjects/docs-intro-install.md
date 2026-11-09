# docs/intro/install

- Subject: docs/intro/install (id `23c160f4-5e61-457f-b2d9-3cecd71c4bd5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 23 of 25
- Conflicts: 0
- Gaps: 0

## Facts

- >>> import django >>> print(django.get_version()) |version| [0cadd575]
- If you do either of the first two steps, keep an eye out for parts of the documentation marked **new in development version**. That phrase flags features that are only available in development versions of Django, and they likely won't work with an official release. [1aef9584]
- Python 3.x.y [GCC 4.x] on linux Type "help", "copyright", "credits" or "license" for more information. >>> [a13c3a9e]
- * :ref:`Install an official release <installing-official-release>`. This is the best approach for most users. [4a79aaad]
- * :ref:`Install the latest development version <installing-development-version>`. This option is for enthusiasts who want the latest-and-greatest features and aren't afraid of running brand new code. You might encounter new bugs in the development version, but reporting them helps the development of Django. Also, releases of third-party packages are less likely to be compatible with the development version than with the latest stable release. [7dc95883]
- * Install a version of Django :ref:`provided by your operating system distribution <installing-distribution-package>`. [8294bd02]
- .. _sqlite: https://www.sqlite.org/ [bfe4c217]
- .. admonition:: Always refer to the documentation that corresponds to the version of Django you're using! [c74e909f]
- .. code-block:: pycon [eaf050be34acb41d-5]
- .. parsed-literal:: [3cb0eef97def623a-2]
- =================== Quick install guide =================== [d5ec01fb]
- Before you can use Django, you'll need to get it installed. We have a :doc:`complete installation guide </topics/install>` that covers all the possibilities; this guide will guide you to a minimal installation that'll work while you walk through the introduction. [1bc9aeb3]
- Being a Python web framework, Django requires Python. See :ref:`faq-python-version-support` for details. Python includes a lightweight database called SQLite_ so you won't need to set up a database just yet. [1c6ad2bd]
- Get the latest version of Python at https://www.python.org/downloads/ or with your operating system's package manager. [922fa349]
- Install Django ============== [353315ce348b58ea-2]
- Install Python ============== [4426f6e8c58b3926-2]
- Set up a database ================= [d9bceb3b]
- That's it -- you can now :doc:`move onto the tutorial </intro/tutorial01>`. [502387af]
- That's it! ========== [3ced5edc]
- This step is only necessary if you'd like to work with a "large" database engine like PostgreSQL, MariaDB, MySQL, or Oracle. To install such a database, consult the :ref:`database installation information <database-installation>`. [1af6f038]
- To verify that Django can be seen by Python, type ``python`` from your shell. Then at the Python prompt, try to import Django: [e77042e6]
- Verifying ========= [9d4faa78]
- You may have another version of Django installed. [7ecfd7ff]

## Beyond the budget

2 more facts did not fit in the budget: [ba87971d] [ec76bd4b]
