# docs/ref/contrib/gis/testing

- Subject: docs/ref/contrib/gis/testing (id `84508a77-b368-4fe8-a866-b6171de6a384`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1373 tokens
- Facts shown: 44 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [7f67a376] Or you may alter the user's role from the SQL shell (assuming this is done from an existing superuser account):
- [444f0888] PostGIS =======
- [6f4876d9cd2b3e11] Settings --------
- [c3d53385] The ``-R -S`` flags indicate that we do not want the user to have the ability to create additional users (roles) or to be a superuser, respectively.
- [a45f7b68] The following is an example bare-bones settings file with spatial backends that can be used to run the entire Django test suite, including those in :mod:`django.contrib.gis`::
- [8d2b0fc7] This may be done at the time the user is created, for example:
- [adfe4cd2] To have the GeoDjango tests executed when :ref:`running the Django test suite <running-unit-tests>` with ``runtests.py`` all of the databases in the settings file must be using one of the :ref:`spatial database backends <spatial-backends>`.
- [bbbb7c74] To make a database user with the ability to create databases, use the following command:
- [8855af9b] To run only the GeoDjango test suite, specify ``gis_tests``:
- [1b95aa83] When GeoDjango's spatial backend initializes on PostGIS, it has to perform an SQL query to determine the version in order to figure out what features are available. Advanced users wishing to prevent this additional query may set the version manually using a 3-tuple of integers specifying the major, minor, and micro version numbers for PostGIS. For example, to configure for PostGIS X.Y.Z you would use::
- [d2adc5915dce89b8-2] Windows -------
- [1c3ec0cb] ``POSTGIS_VERSION`` ~~~~~~~~~~~~~~~~~~~
