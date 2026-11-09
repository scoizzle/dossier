# docs/releases/1.11.1

- Subject: docs/releases/1.11.1 (id `c4005c57-7e4d-42e1-9080-e0b6646525d8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1467 tokens
- Facts shown: 37 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- * Allowed prefetch calls on managers with custom ``ModelIterable`` subclasses (:ticket:`28096`). [42da3a62]
- * Corrected the return type of ``ArrayField(CITextField())`` values retrieved from the database (:ticket:`28161`). [4e3f1b05]
- * Corrected the stack level of unordered queryset pagination warnings (:ticket:`28109`). [330f8c1d]
- * Fixed ``QuerySet.filter()`` crash when it references the name of a ``OneToOneField`` primary key (:ticket:`28047`). [955a18ab]
- * Fixed ``QuerySet.prefetch_related()`` crash when fetching relations in nested ``Prefetch`` objects (:ticket:`27554`). [e5c5ede3]
- * Fixed a crash when using a 2-tuple in ``EmailMessage``’s ``attachments`` argument (:ticket:`28042`). [686b9831]
- * Fixed a crash when using a ``__icontains`` lookup on a ``ArrayField`` (:ticket:`28038`). [7482b00c]
- * Fixed a regression causing ``__in`` lookups on a foreign key to fail when using the foreign key's parent model as the lookup value (:ticket:`28175`). [068690b3]
- * Fixed a regression causing incorrect queries for ``__in`` subquery lookups when models use ``ForeignKey.to_field`` (:ticket:`28101`). [ff9c49ba]
- * Fixed a regression in choice ordering in form fields with grouped and non-grouped options (:ticket:`28157`). [c3ac1536]
- * Fixed a regression in formset ``min_num`` validation with unchanged forms that have initial data (:ticket:`28130`). [c42ef9bc]
- * Fixed a regression where ``CheckboxSelectMultiple``, ``NullBooleanSelect``, ``RadioSelect``, ``SelectMultiple``, and ``Select`` localized option values (:ticket:`28075`). [21e1d9a3]
- * Fixed a regression where ``Model._state.db`` wasn't set correctly on multi-table inheritance parent models after saving a child model (:ticket:`28166`). [7263969c]
- * Fixed change password link in the ``contrib.auth`` admin for ``el``, ``es_MX``, and ``pt`` translations (:ticket:`28100`). [40cf06f4]
- * Fixed crash in ``BaseInlineFormSet._construct_form()`` when using ``save_as_new`` (:ticket:`28159`). [fcc0095a]
- * Fixed crash in ``BaseGeometryWidget.get_context()`` when overriding existing ``attrs`` (:ticket:`28105`). [00c6fb52]
- * Fixed crash in ``BaseGeometryWidget.subwidgets()`` (:ticket:`28039`). [dd598d8f]
- * Fixed crash when overriding the template of ``django.views.static.directory_index()`` (:ticket:`28122`). [b2f18a5c]
- * Fixed empty POST data table appearing instead of "No POST data" in HTML debug page (:ticket:`28079`). [4ed22ee8]
- * Fixed exception reraising in ORM query execution when ``cursor.execute()`` fails and the subsequent ``cursor.close()`` also fails (:ticket:`28091`). [17195919]
- * Fixed layout of ``ReadOnlyPasswordHashWidget`` (used in the admin's user change page) (:ticket:`28097`). [e13f897e]
- * Made migrations respect ``Index``’s ``name`` argument. If you created a named index with Django 1.11, ``makemigrations`` will create a migration to recreate the index with the correct name (:ticket:`28051`). [6e94fb64]

## All facts

- [cd84744f] * Prepared for ``cx_Oracle`` 6.0 support (:ticket:`28138`).
- [1b0d981a] * Prevented ``AddIndex`` and ``RemoveIndex`` from mutating model state (:ticket:`28043`).
- [d1737c4b] * Prevented ``SessionBase.cycle_key()`` from losing session data if ``_session_cache`` isn't populated (:ticket:`28066`).
- [5e50a225] * Prevented hiding GDAL errors if it's not installed when using ``contrib.gis`` (:ticket:`28160`). (It's a required dependency as of Django 1.11.)
- [bb607c03] * Prevented migrations from dropping database indexes from ``Meta.indexes`` when changing ``Field.db_index`` to ``False`` (:ticket:`28052`).
- [6c6d8edb] * Restored ``BoundField``\s without any ``choices`` evaluating to ``True`` (:ticket:`28058`).
- [d41ecbce] * Restored the output of the ``class`` attribute in the ``<ul>`` of widgets that use the ``multiple_input.html`` template. This fixes ``ModelAdmin.radio_fields`` with ``admin.HORIZONTAL`` (:ticket:`28059`).
- [1f964dbf] * Updated the ``contrib.postgres`` ``SplitArrayWidget`` to use template-based widget rendering (:ticket:`28040`).
- [56d124fd] *May 6, 2017*
- [8cd50570] =========================== Django 1.11.1 release notes ===========================
- [e09a6810] Allowed disabling server-side cursors on PostgreSQL ===================================================
- [6c84539cac9c976c-8] Bugfixes ========
- [813df96d] Django 1.11.1 adds a minor feature and fixes several bugs in 1.11.
- [52d110a28852d7b2-2] See :ref:`transaction-pooling-server-side-cursors` for more discussion.
- [ecb929eb] The change in Django 1.11 to make :meth:`.QuerySet.iterator` use server-side cursors on PostgreSQL prevents running Django with PgBouncer in transaction pooling mode. To reallow that, use the :setting:`DISABLE_SERVER_SIDE_CURSORS <DATABASE-DISABLE_SERVER_SIDE_CURSORS>` setting in :setting:`DATABASES`.
