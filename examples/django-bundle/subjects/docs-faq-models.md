# docs/faq/models

- Subject: docs/faq/models (id `f813ab5c-bc06-4a48-9617-ea327da360cb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 27 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- >>> from django.db import connection >>> connection.queries [{'sql': 'SELECT polls_polls.id, polls_polls.question, polls_polls.pub_date FROM polls_polls', 'time': '0.002'}] [178c1a0f]
- >>> from django.db import connections >>> connections["my_db_alias"].queries [1fd16d2c]
- ALTER TABLE myapp_mytable ENGINE=MyISAM; [915495df]
- from django.db import reset_queries [4a0edba7]
- reset_queries() [85127c18]
- * ``sql`` - The raw SQL statement * ``time`` - How long the statement took to execute, in seconds. [3ef7ed9a]
- .. _faq-see-raw-sql-queries: [b551db45]
- .. _the wiki page: https://code.djangoproject.com/wiki/NoSqlSupport [70dd0b9f]
- .. code-block:: pycon [eaf050be34acb41d]
- .. code-block:: pycon [eaf050be34acb41d-2]
- .. code-block:: sql [0ee73173f492412a]
- ========================= FAQ: Databases and models ========================= [61b24bf9]
- Can I use Django with a preexisting database? ============================================= [e9ce7971]
- Do Django models support multiple-column primary keys? ====================================================== [6dbf0bdd]
- Does Django support NoSQL databases? ==================================== [9d2c2a53]
- For example, if you're using MySQL and want your tables to use the MyISAM table type, use the following SQL: [66b59aa0]
- How can I see the raw SQL queries Django is running? ==================================================== [1bf54cea]
- How do I add database-specific options to my CREATE TABLE statements, such as specifying MyISAM as the table type? ================================================================================================================== [44e1ffd5]
- If I make changes to a model, how do I update the database? =========================================================== [d0b3240c]
- If you are using :doc:`multiple databases</topics/db/multi-db>`, you can use the same interface on each member of the ``connections`` dictionary: [dda119eb]
- If you don't mind clearing data, your project's ``manage.py`` utility has a :djadmin:`flush` option to reset the database to the state it was in immediately after :djadmin:`migrate` was executed. [8094527d]
- If you need to clear the query list manually at any point in your functions, call ``reset_queries()``, like this:: [296ffe9e]
- Make sure your Django :setting:`DEBUG` setting is set to ``True``. Then do this: [59c63183]
- NoSQL databases are not officially supported by Django itself. There are, however, a number of side projects and forks which allow NoSQL functionality in Django. [cd5fe6c4]
- Partially. See :doc:`/topics/composite-primary-key`. [db701bd9]
- Take a look at Django's support for :mod:`schema migrations <django.db.migrations>`. [591375d0]
- Yes. See :doc:`Integrating with a legacy database </howto/legacy-databases>`. [58dc5061]

## Beyond the budget

4 more facts did not fit in the budget: [7f608e7d] [cd6f557f] [923ceb3a] [510ef2b7]
