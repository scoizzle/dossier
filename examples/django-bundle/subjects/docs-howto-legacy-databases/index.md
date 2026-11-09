# docs/howto/legacy-databases

- Subject: docs/howto/legacy-databases (id `a96e3e43-b94c-4df2-94ff-39fcf4f839f9`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 987 tokens
- Facts shown: 26 of 26
- Conflicts: 0
- Gaps: 0

## Highlights

- class Meta: managed = False db_table = "CENSUS_PERSONS" [7c1285b0]
- $ python manage.py inspectdb [03576847]
- $ python manage.py inspectdb > models.py [a20b04e7]
- $ python manage.py migrate [bdbd2b79172db241]
- class Person(models.Model): id = models.IntegerField(primary_key=True) first_name = models.CharField(max_length=70) [996c316b]
- * :setting:`NAME` * :setting:`ENGINE <DATABASE-ENGINE>` * :setting:`USER` * :setting:`PASSWORD` * :setting:`HOST` * :setting:`PORT` [02d5a6fe]
- .. code-block:: shell [8aa7203c166b13be-17]
- .. code-block:: shell [8aa7203c166b13be-18]
- .. code-block:: shell [8aa7203c166b13be-19]
- ============================================== How to integrate Django with a legacy database ============================================== [8213601b]
- Auto-generate the models ======================== [ca64309c]
- By default, :djadmin:`inspectdb` creates unmanaged models. That is, ``managed = False`` in the model's ``Meta`` class tells Django not to manage each table's creation, modification, and deletion:: [2a8fd16a]
- Django comes with a utility called :djadmin:`inspectdb` that can create models by introspecting an existing database. You can view the output by running this command: [ab162d2e]
- Give Django your database parameters ==================================== [395073ff]
- If you do want to allow Django to manage the table's lifecycle, you'll need to change the :attr:`~django.db.models.Options.managed` option above to ``True`` (or remove it because ``True`` is its default value). [f42828ae]
- Install the core Django tables ============================== [2e4b5395]
- Next, run the :djadmin:`migrate` command to install any extra needed database records such as admin permissions and content types: [0e728e05]
- Once you've cleaned up your models, name the file ``models.py`` and put it in the Python package that holds your app. Then add the app to your :setting:`INSTALLED_APPS` setting. [bb0244a4]
- Once you've got Django set up, you'll follow this general process to integrate with an existing database. [a0f48287]
- Save this as a file by using standard Unix output redirection: [307917a1]
- Test and tweak ============== [49083a1b]
- This document assumes you know the Django basics, as covered in the :doc:`tutorial </intro/tutorial01>`. [e7a44698]
- This feature is meant as a shortcut, not as definitive model generation. See the :djadmin:`documentation of inspectdb <inspectdb>` for more information. [fc4f2ebb]
- Those are the basic steps -- from here you'll want to tweak the models Django generated until they work the way you'd like. Try accessing your data via the Django database API, and try editing objects via Django's admin site, and edit the models file accordingly. [7048f91a]

## All facts

- [d8afd87c] While Django is best suited for developing new applications, it's quite possible to integrate it into legacy databases. Django includes a couple of utilities to automate as much of this process as possible.
- [fa0b7c39] You'll need to tell Django what your database connection parameters are, and what the name of the database is. Do that by editing the :setting:`DATABASES` setting and assigning values to the following keys for the ``'default'`` connection:
