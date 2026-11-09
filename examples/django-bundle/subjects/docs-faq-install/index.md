# docs/faq/install

- Subject: docs/faq/install (id `37fb21b5-93d3-4cf8-87ba-3b2d18882c5e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 15 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- #. `Download the code`_. #. Install Django (read the :doc:`installation guide </intro/install>`). #. Walk through the :doc:`tutorial </intro/tutorial01>`. #. Check out the rest of the :doc:`documentation </index>`, and `ask questions`_ if you run into trouble. [9580a640]
- .. _Python: https://www.python.org/ .. _PostgreSQL: https://www.postgresql.org/ .. _MariaDB: https://mariadb.org/ .. _MySQL: https://www.mysql.com/ .. _`SQLite`: https://www.sqlite.org/ .. _Oracle: https://www.oracle.com/ [d0594133]
- .. _`Download the code`: https://www.djangoproject.com/download/ .. _ask questions: https://www.djangoproject.com/community/ [d57f2e35]
- .. _faq-python-version-support: [cdc42b05]
- ============== =============== Django version Python versions ============== =============== 4.2 3.8, 3.9, 3.10, 3.11, 3.12 (added in 4.2.8) 5.0 3.10, 3.11, 3.12 5.1 3.10, 3.11, 3.12, 3.13 (added in 5.1.3) 5.2 3.10, 3.11, 3.12, 3.13, 3.14 (added in 5.2.8) 6.0 3.12, 3.13, 3.14 6.1 3.12, 3.13, 3.14, 3.15 (added in 6.1.3) ============== =============== [93dc4e56]
- ================= FAQ: Installation ================= [6ffa2bf3]
- Django comes with its own lightweight development server (:djadmin:`runserver`). For a production environment, Django follows the WSGI spec, :pep:`3333`, which means it can run on a variety of web servers. See :doc:`/howto/deployment/index` for more information. [2dbc2b68]
- Django requires Python. See the table in the next question for the versions of Python that work with each version of Django. Other Python libraries may be required for some use cases, but you'll receive an error about them as they're needed. [e1db0f71]
- Django runs `SQLite`_ by default, which is included in Python installations. For a production environment, we recommend PostgreSQL_; but we also officially support MariaDB_, MySQL_, `SQLite`_, and Oracle_. See :doc:`Supported Databases </ref/databases>` for more information. [606ecd3c]
- For a development environment -- if you just want to experiment with Django -- you don't need to have a separate web server installed or database server. [28816e1c]
- For each version of Python, only the latest micro release (A.B.C) is officially supported. Python versions that have reached end-of-life are no longer maintained by the Python project and therefore should not be used with Django. [4451422d]
- Generally, if you're using code in production, you should be using a stable release. The Django project publishes a full stable release every eight months or so, with bugfix updates in between. These stable releases contain the API that is covered by our backwards compatibility guarantees; if you write code against stable releases, you shouldn't have any problems upgrading when the next official version is released. [636891ab]
- How do I get started? ===================== [ea47fd34]
- Should I use the stable version or development version? ======================================================= [24b0e46d]
- Since newer versions of Python are often faster, have more features, and are better supported, the latest version of Python 3 is recommended. [c3567684]

## Beyond the budget

6 more facts did not fit in the budget: [fe908596] [faa4b613] [67c20a0d] [ff6177cd] [043c6b2f] [d6786ab0]
