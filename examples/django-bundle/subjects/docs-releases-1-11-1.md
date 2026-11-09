# docs/releases/1.11.1

- Subject: docs/releases/1.11.1 (id `9b75bf72-81b7-49c3-bf4c-a7cea994ef22`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 22 of 37
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

15 more facts did not fit in the budget: [cd84744f] [1b0d981a] [d1737c4b] [5e50a225] [bb607c03] [6c6d8edb] [d41ecbce] [1f964dbf] [56d124fd] [8cd50570] [e09a6810] [6c84539cac9c976c-8] [813df96d] [52d110a28852d7b2-2] [ecb929eb]
