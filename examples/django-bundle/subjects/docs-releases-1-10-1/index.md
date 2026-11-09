# docs/releases/1.10.1

- Subject: docs/releases/1.10.1 (id `ad8ffd6a-127d-4d06-8880-c56bc4a04251`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1152 tokens
- Facts shown: 27 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- * Added the database alias to the ``InconsistentMigrationHistory`` message raised by ``makemigrations`` and ``migrate`` (:ticket:`27089`). [bb6f280b]
- * Allowed ``User.is_authenticated`` and ``User.is_anonymous`` properties to be compared using ``==``, ``!=``, and ``|`` (:ticket:`26988`, :ticket:`27154`). [86f2021a]
- * Fixed ``ClearableFileInput`` to avoid the ``required`` HTML attribute when initial data exists (:ticket:`27037`). [7a41c9c3]
- * Fixed ``contrib.admindocs`` crash when a view is in a class, such as some of the admin views (:ticket:`27018`). [f83a3598]
- * Fixed a checks framework crash with an empty ``Meta.default_permissions`` (:ticket:`26997`). [e69892b6]
- * Fixed a crash if ``request.META['CONTENT_LENGTH']`` is an empty string (:ticket:`27005`). [24b881a2]
- * Fixed a crash in MySQL connections where ``SELECT @@SQL_AUTO_IS_NULL`` doesn't return a result (:ticket:`26991`). [739c5730]
- * Fixed a regression in ``Client.force_login()`` which required specifying a ``backend`` rather than automatically using the first one if multiple backends are configured (:ticket:`27027`). [a71d5296]
- * Fixed a regression in model forms where model fields with a ``default`` that didn't appear in POST data no longer used the ``default`` (:ticket:`27039`). [58eeb5c7]
- * Fixed a regression in the number of queries when using ``RadioSelect`` with a ``ModelChoiceField`` form field (:ticket:`27001`). [502b22b2]
- * Fixed annotations with database functions when combined with lookups on PostGIS (:ticket:`27014`). [ca85ffe6]
- * Fixed crash of ``django.views.static.serve()`` with ``show_indexes`` enabled (:ticket:`26973`). [d94b648d]
- * Fixed the ``isnull`` lookup on a ``ForeignKey`` with its ``to_field`` pointing to a ``CharField`` or pointing to a ``CharField`` defined with ``primary_key=True`` (:ticket:`26983`). [ca2876e3]
- * Fixed the creation of ``ContentType`` and ``Permission`` objects for models of applications without migrations when calling the ``migrate`` command with no migrations to apply (:ticket:`27044`). [cbf4ca63]
- * Included the already applied migration state changes in the ``Apps`` instance provided to the ``pre_migrate`` signal receivers to allow ``ContentType`` renaming to be performed on model rename (:ticket:`27100`). [2e7366f5]
- * Made ``QuerySet.bulk_create()`` properly initialize model instances on backends, such as PostgreSQL, that support returning the IDs of the created records so that many-to-many relationships can be used on the new objects (:ticket:`27026`). [806f4a9c]
- * Made ``makemigrations`` skip inconsistent history checks on non-default databases if database routers aren't in use or if no apps can be migrated to the database (:ticket:`27054`, :ticket:`27110`, :ticket:`27142`). [99252cb0]
- * Prevented the ``migrate`` command from raising ``InconsistentMigrationHistory`` in the presence of unapplied squashed migrations (:ticket:`27004`). [b42f76b7]
- * Reallowed the ``{% for %}`` tag to unpack any iterable (:ticket:`27058`). [d2b66b5d]

## All facts

- [85ecfb83] * Reallowed subclassing ``UserCreationForm`` without ``USERNAME_FIELD`` in ``Meta.fields`` (:ticket:`27111`).
- [60d8402e] * Removed duplicated managers in ``Model._meta.managers`` (:ticket:`27073`).
- [4d77d743] * Removed the broken ``BaseCommand.usage()`` method which was for ``optparse`` support (:ticket:`27000`).
- [823104d2] * Reverted a few admin checks that checked ``field.many_to_many`` back to ``isinstance(field, models.ManyToManyField)`` since it turned out the checks weren't suitable to be generalized like that (:ticket:`26998`).
- [656cce6b] *September 1, 2016*
- [e0fdf200] =========================== Django 1.10.1 release notes ===========================
- [6c84539cac9c976c] Bugfixes ========
- [fcf8e854] Django 1.10.1 fixes several bugs in 1.10.
