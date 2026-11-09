# docs/howto/initial-data

- Subject: docs/howto/initial-data (id `ea425309-8ef1-4c2e-8442-b0039ebaf330`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1123 tokens
- Facts shown: 24 of 25
- Conflicts: 0
- Gaps: 0

## Highlights

- - model: myapp.person pk: 1 fields: first_name: John last_name: Lennon - model: myapp.person pk: 2 fields: first_name: Paul last_name: McCartney [c4e92313]
- Django will use the first fixture file it finds whose name matches, so if you have fixture files with the same name in different applications, you will be unable to distinguish between them in your ``loaddata`` commands. The easiest way to avoid this problem is by *namespacing* your fixture files. That is, by putting them inside a directory named for their application, as in the relative path example above. [5b09746c]
- Fixtures are also used by the :ref:`testing framework <topics-testing-fixtures>` to help set up a consistent test environment. [d60ad91f]
- .. _PyYAML: https://pyyaml.org/ [d0c25b90]
- .. _initial-data-via-fixtures: [d1649042]
- .. admonition:: Namespace your fixture files [41421ccc]
- .. code-block:: js [df112e94]
- .. code-block:: yaml [8601ee87]
- .. seealso:: [6b4a5e54e001d097-6]
- ====================================== How to provide initial data for models ====================================== [ce50c4ab]
- A fixture is a collection of data that Django knows how to import into a database. The most straightforward way of creating a fixture if you've already got some data is to use the :djadmin:`manage.py dumpdata <dumpdata>` command. Or, you can write fixtures by hand; fixtures can be written as JSON, XML or YAML (with PyYAML_ installed) documents. The :doc:`serialization documentation </topics/serialization>` has more details about each of these supported :ref:`serialization formats <serialization-formats>`. [637555a0]
- And here's that same fixture as YAML: [b62cfab8]
- As an example, though, here's what a fixture for a ``Person`` model might look like in JSON: [9557c4b5]
- By default, Django looks for fixtures in the ``fixtures`` directory inside each app, so the command ``loaddata sample`` will find the file ``my_app/fixtures/sample.json``. This works with relative paths as well, so ``loaddata my_app/sample`` will find the file ``my_app/fixtures/my_app/sample.json``. [560bd467]
- Django also looks for fixtures in the list of directories provided in the :setting:`FIXTURE_DIRS` setting. [88cd4cf6]
- It's sometimes useful to prepopulate your database with hardcoded data when you're first setting up an app. You can provide initial data with migrations or fixtures. [7de7852c]
- Provide data with fixtures ========================== [2747bc24]
- Provide initial data with migrations ==================================== [27f57463]
- Tell Django where to look for fixture files ------------------------------------------- [eebfe8d2]
- To automatically load initial data for an app, create a :ref:`data migration <data-migrations>`. Migrations are run when setting up the test database, so the data will be available there, subject to :ref:`some limitations <test-case-serialized-rollback>`. [bd4ab1f6]

## All facts

- [8c30a932] To completely prevent default search from happening, use an absolute path to specify the location of your fixture file, e.g. ``loaddata /path/to/sample``.
- [3de00c7e] You can also provide data using :ref:`fixtures <fixtures-explanation>`, however, this data isn't loaded automatically, except if you use :attr:`.TransactionTestCase.fixtures`.
- [fce1cf31] You can load data by calling :djadmin:`manage.py loaddata <loaddata>` ``<fixturename>``, where ``<fixturename>`` is the name of the fixture file you've created. Each time you run :djadmin:`loaddata`, the data will be read from the fixture and reloaded into the database. Note this means that if you change one of the rows created by a fixture and then run :djadmin:`loaddata` again, you'll wipe out any changes you've made.
- [6590a4cf] You'll store this data in a ``fixtures`` directory inside your app.
