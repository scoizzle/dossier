# docs/ref/models/class

- Subject: docs/ref/models/class (id `10193dec-f203-4e05-b2a7-f324337cd79f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 21 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- class Person(models.Model): # Add manager with another name people = models.Manager() [52722079]
- from django.db import models [4af926756c29efa6-16]
- Django provides a ``DoesNotExist`` exception as an attribute of each model class to identify the class of object that could not be found, allowing you to catch exceptions for a particular model class. The exception is a subclass of :exc:`django.core.exceptions.ObjectDoesNotExist`. [34b65236]
- Django provides a ``MultipleObjectsReturned`` exception as an attribute of each model class to identify the class of object for which multiple objects were found, allowing you to catch exceptions for a particular model class. The exception is a subclass of :exc:`django.core.exceptions.MultipleObjectsReturned`. [1e8e4802]
- Django provides a ``NotUpdated`` exception as an attribute of each model class to identify the class of object that could not be updated, allowing you to catch exceptions for a particular model class. The exception is a subclass of :exc:`django.core.exceptions.ObjectNotUpdated` and inherits from :exc:`django.db.DatabaseError` for backward compatibility reasons. [4d683431]
- Each non-abstract :class:`~django.db.models.Model` class must have a :class:`~django.db.models.Manager` instance added to it. Django ensures that in your model class you have at least a default ``Manager`` specified. If you don't add your own ``Manager``, Django will add an attribute ``objects`` containing default :class:`~django.db.models.Manager` instance. If you add your own :class:`~django.db.models.Manager` instance attribute, the default one does not appear. Consider the following example:: [c1764fad]
- For more details on model managers see :doc:`Managers </topics/db/managers>` and :ref:`Retrieving objects <retrieving-objects>`. [f91c0817]
- This exception is raised by :meth:`.QuerySet.get` when multiple objects are found for the given lookups. [7fb38f93]
- This exception is raised by the ORM when an expected object is not found. For example, :meth:`.QuerySet.get` will raise it when no object is found for the given lookups. [064f4a12]
- This exception is raised when :ref:`a forced update <ref-models-force-insert>` of a :class:`~django.db.models.Model` instance does not affect any rows. [01cf460f]
- .. attribute:: Model.objects [150456c2]
- .. currentmodule:: django.db.models [3a368b18514a814b-3]
- .. exception:: Model.DoesNotExist [ec8a6551]
- .. exception:: Model.MultipleObjectsReturned [e35323a3]
- .. exception:: Model.NotUpdated [3dbf0b44]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-24]
- ===================== Model class reference ===================== [cb6fd269]
- Attributes ========== [1aaa4a27458d239d]
- This document covers features of the :class:`~django.db.models.Model` class. For more information about models, see :doc:`the complete list of Model reference guides </ref/models/index>`. [a0d99c8d]
- ``DoesNotExist`` ---------------- [92ebc6de]
- ``MultipleObjectsReturned`` --------------------------- [77c87fbbd18bdfb0-2]

## Beyond the budget

2 more facts did not fit in the budget: [536c3c62] [a4e68a78]
