# docs/releases/1.11.3

- Subject: docs/releases/1.11.3 (id `42c38d47-759c-4285-8d31-acfc974eb1d4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 835 tokens
- Facts shown: 19 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed ``QuerySet.union()``, ``intersection()``, and ``difference()`` when combining with an ``EmptyQuerySet`` (:ticket:`28293`). [faa3683e]
- * Fixed ``UnboundLocalError`` crash in ``RenameField`` with nonexistent field (:ticket:`28350`). [4bb4d0a8]
- * Fixed a regression causing ``Model.__init__()`` to crash if a field has an instance only descriptor (:ticket:`28269`). [9e4c928d]
- * Fixed a regression preventing a model field's ``limit_choices_to`` from being evaluated when a ``ModelForm`` is instantiated (:ticket:`28345`). [ca02c20b]
- * Fixed admin's ``FieldListFilter.get_queryset()`` crash on invalid input (:ticket:`28202`). [c274366e]
- * Fixed an incorrect ``DisallowedModelAdminLookup`` exception when using a nested reverse relation in ``list_filter`` (:ticket:`28262`). [4bc0593b]
- * Fixed crash in admin's inlines when a model has an inherited non-editable primary key (:ticket:`27967`). [3af4c186]
- * Fixed invalid HTML for a required ``AdminFileWidget`` (:ticket:`28278`). [d623184c]
- * Fixed model initialization to set the name of class-based model indexes for models that only inherit ``models.Model`` (:ticket:`28282`). [0a1ca31c]
- * Fixed the value of ``redirect_field_name`` in ``LoginView``’s template context. It's now an empty string (as it is for the original function-based ``login()`` view) if the corresponding parameter isn't sent in a request (in particular, when the login page is accessed directly) (:ticket:`28229`). [950b3504]
- * Prevented ``Paginator``’s unordered object list warning from evaluating a ``QuerySet`` (:ticket:`28284`). [fbd88bfa]
- * Prevented a primary key alteration from adding a foreign key constraint if ``db_constraint=False`` (:ticket:`28298`). [f87f1dde]
- * Prevented attribute values in the ``django/forms/widgets/attrs.html`` template from being localized so that numeric attributes (e.g. ``max`` and ``min``) of ``NumberInput`` work correctly (:ticket:`28303`). [2e9bbec2]
- * Removed an incorrect deprecation warning about a missing ``renderer`` argument if a ``Widget.render()`` method accepts ``**kwargs`` (:ticket:`28265`). [56e8ad2c]
- * Removed casting of the option value to a string in the template context of the ``CheckboxSelectMultiple``, ``NullBooleanSelect``, ``RadioSelect``, ``SelectMultiple``, and ``Select`` widgets (:ticket:`28176`). In Django 1.11.1, casting was added in Python to avoid localization of numeric values in Django templates, but this made some use cases more difficult. Casting is now done in the template using the ``|stringformat:'s'`` filter. [e38839b7]
- *July 1, 2017* [57af448d]
- =========================== Django 1.11.3 release notes =========================== [60e86cbf]
- Bugfixes ======== [6c84539cac9c976c-21]
- Django 1.11.3 fixes several bugs in 1.11.2. [804a29f4]
