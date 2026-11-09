# docs/releases/1.11.4

- Subject: docs/releases/1.11.4 (id `c19064dd-654f-459a-8d44-5b96b7d89149`)
- Kind: subject
- Budget: 1200 tokens
- Used: 515 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- * Corrected ``Field.has_changed()`` to return ``False`` for disabled form fields: ``BooleanField``, ``MultipleChoiceField``, ``MultiValueField``, ``FileField``, ``ModelChoiceField``, and ``ModelMultipleChoiceField``. [986ddd84]
- * Fixed ``ClearableFileInput`` rendering as a subwidget of ``MultiWidget`` (:ticket:`28414`). Custom ``clearable_file_input.html`` widget templates will need to adapt for the fact that context values ``checkbox_name``, ``checkbox_id``, ``is_initial``, ``input_text``, ``initial_text``, and ``clear_checkbox_label`` are now attributes of ``widget`` rather than appearing in the top-level context. [02774304]
- * Fixed ``QuerySet.count()`` for ``union()``, ``difference()``, and ``intersection()`` queries. (:ticket:`28399`). [2cef6485]
- * Fixed ``QuerySet.union()`` and ``difference()`` when combining with a queryset raising ``EmptyResultSet`` (:ticket:`28378`). [f288625d]
- * Fixed a regression in 1.11.3 on Python 2 where non-ASCII ``format`` values for date/time widgets results in an empty ``value`` in the widget's HTML (:ticket:`28355`). [e40c7bac]
- * Fixed a regression in pickling of ``LazyObject`` on Python 2 when the wrapped object doesn't have ``__reduce__()`` (:ticket:`28389`). [9cac6a77]
- * Fixed crash in ``runserver``'s ``autoreload`` with Python 2 on Windows with non-``str`` environment variables (:ticket:`28174`). [d9b0792d]
- * Fixed queryset crash when using a ``GenericRelation`` to a proxy model (:ticket:`28418`). [39a2f811]
- *August 1, 2017* [9caabcb6]
- =========================== Django 1.11.4 release notes =========================== [91368c45]
- Bugfixes ======== [6c84539cac9c976c-22]
- Django 1.11.4 fixes several bugs in 1.11.3. [caa9374f]
