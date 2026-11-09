# docs/ref/contrib/gis/testing

- Subject: docs/ref/contrib/gis/testing (id `072a50b0-7434-47e8-a3a4-50b9962a39a9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 32 of 44
- Conflicts: 0
- Gaps: 0

## Facts

- $ ./runtests.py --settings=postgis [766d89cd]
- $ ./runtests.py --settings=postgis gis_tests [24eaa8b6]
- $ createuser --createdb -R -S <user_name> [74e89dd3]
- $ createuser --superuser <user_name> [cc01a205]
- DATABASES = { "default": { "ENGINE": "django.contrib.gis.db.backends.postgis", "NAME": "geodjango", "USER": "geodjango", }, "other": { "ENGINE": "django.contrib.gis.db.backends.postgis", "NAME": "other", "USER": "geodjango", }, } [c0b10e07]
- POSTGIS_VERSION = (X, Y, Z) [15ae1e2d]
- SECRET_KEY = "django_tests_secret_key" [fb199bc1]
- The settings below have sensible defaults, and shouldn't require manual setting. [fd2e294c]
- postgres# ALTER ROLE <user_name> CREATEDB NOSUPERUSER NOCREATEROLE; [f5959b6d]
- postgres# ALTER ROLE <user_name> SUPERUSER; [6d07f7db]
- .. _geodjango-tests: [cfdef1a1]
- .. _testing-postgis: [b7f71ef3]
- .. code-block:: psql [e959c9cb2ba15358-2]
- .. code-block:: psql [e959c9cb2ba15358-3]
- .. code-block:: shell [8aa7203c166b13be-106]
- .. code-block:: shell [8aa7203c166b13be-107]
- .. code-block:: shell [8aa7203c166b13be-108]
- .. code-block:: shell [8aa7203c166b13be-109]
- .. note:: [942ae6c11625c81c-72]
- .. setting:: POSTGIS_VERSION [ba15e01e]
- ====================== Testing GeoDjango apps ====================== [9d27226c]
- Alternatively, you may alter an existing user's role from the SQL shell (assuming this is done from an existing superuser account): [e51dac18]
- Assuming the settings above were in a ``postgis.py`` file in the same directory as ``runtests.py``, then all Django and GeoDjango tests would be performed when executing the command: [d77164e3]
- By default, the PostGIS installer on Windows includes a template spatial database entitled ``template_postgis``. [19bf740f]
- Create database superuser ~~~~~~~~~~~~~~~~~~~~~~~~~ [f1f43362]
- Create database user ~~~~~~~~~~~~~~~~~~~~ [7cc83d6f]
- Depending on your configuration, this section describes several methods to configure a database user with sufficient privileges to run tests for GeoDjango applications on PostgreSQL. If your :ref:`spatial database template <spatialdb_template>` was created like in the instructions, then your testing database user only needs to have the ability to create databases. In other configurations, you may be required to use a database superuser. [ce872a73]
- Example ------- [84675e43a58d58cc-2]
- GeoDjango tests =============== [f43303e2]
- Included in this documentation are some additional notes and settings for :ref:`testing-postgis` users. [8b507de8]
- Obtaining sufficient privileges ------------------------------- [71558b41]
- On Windows platforms you can use the pgAdmin III utility to add superuser privileges to your database user. [01bef848]

## Beyond the budget

11 more facts did not fit in the budget: [444f0888] [6f4876d9cd2b3e11] [c3d53385] [a45f7b68] [8d2b0fc7] [adfe4cd2] [bbbb7c74] [8855af9b] [1b95aa83] [d2adc5915dce89b8-2] [1c3ec0cb]
