# docs/releases/1.0

- Subject: docs/releases/1.0 (id `459093f6-f900-4abb-ace4-d6f44fc9a9b8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 19 of 66
- Conflicts: 0
- Gaps: 0

## Facts

- class Child(Parent): father = models.OneToOneField( Parent, primary_key=True, to_field="other_value", parent_link=True ) value = models.IntegerField() [b03071a2]
- class Parent(models.Model): name = models.CharField(max_length=10) other_value = models.IntegerField(unique=True) [4e090b5a]
- 1.0-porting-guide [8b2aeeda]
- This feature is new in Django 1.0 [69d8597d]
- * https://docs.djangoproject.com/ [aa9fb262]
- - :ref:`mysql-notes` - :ref:`sqlite-notes` - :ref:`oracle-notes` [97bb561e]
- .. _Geographic Information Systems: https://en.wikipedia.org/wiki/Geographic_information_system [77f390e1]
- .. _Jython: https://www.jython.org/ [6fa84f57]
- .. toctree:: :maxdepth: 1 [2237daa5fedafa78-17]
- .. versionadded:: 1.0 [dcd05c30]
- ======================== Django 1.0 release notes ======================== [60d81a9c]
- A *lot*! [154d25d3]
- A complete list of backwards-incompatible changes can be found at https://code.djangoproject.com/wiki/BackwardsIncompatibleChanges. [6475be9c]
- A number of features and methods which had previously been marked as deprecated, and which were scheduled for removal prior to the 1.0 release, are no longer present in Django. These include imports of the form library from ``django.newforms`` (now located simply at ``django.forms``), the ``form_for_model`` and ``form_for_instance`` helper functions (which have been replaced by ``ModelForm``) and a number of deprecated features which were replaced by the dispatcher, file-uploading and file-storage refactoring introduced in the Django 1.0 alpha releases. [6ffbfb59]
- A project over a year in the making, this adds world-class GIS (`Geographic Information Systems`_) support to Django, in the form of a ``contrib`` application. Its documentation is currently being maintained externally, and will be merged into the main Django documentation shortly. Huge thanks go to Justin Bronn, Jeremy Dunck, Brett Hoerner and Travis Pinney for their efforts in creating and completing this feature. [6347d88c]
- Although Django's default behavior of having a model's ``save()`` method automatically determine whether to perform an ``INSERT`` or an ``UPDATE`` at the SQL level is suitable for the majority of cases, there are occasional situations where forcing one or the other is useful. As a result, models can now support an additional parameter to ``save()`` which can force a specific operation. [9a87ef3e]
- An improved ORM --------------- [6377b310]
- An interesting historical note: when Django was first released in July 2005, the initial released version of Django came from an internal repository at revision number 8825. Django 1.0 represents revision 8961 of our public repository. It seems fitting that our 1.0 release comes at the moment where community contributions overtake those made privately. [62742788]
- As part of a Google Summer of Code project, Thejaswi Puthraya carried out a major rewrite and refactoring of Django's bundled comment system, greatly increasing its flexibility and customizability. [3f0f63dd]

## Beyond the budget

47 more facts did not fit in the budget: [3ee7ae5b] [463b3b5f48db2249-2] [438668a9] [57b15d40] [4d2849af] [72afa85f] [5ed0e707] [3772d803] [3539eab7] [6cb33942] [9d7ec7c9] [3253eee4] [ab7165d1] [501e2904] [3a4a979f] [4252a9cb] [d12a7df8] [1b41c03e] [40672f31] [724e0a54] [0ea86c3b] [3d5ed3d2] [29d8bc0a] [306e6239] [62706306] [791501b2] [87b2445b] [0f63727b] [a00a3daa] [907cdc34] [6bae78b5] [96e00993] [7a061b5f] [813f1129] [d68a9a7f] [2e139b8c] [ed3d0cbd] [6246540f] [cf8e1a9f] [121a4932] [d88754b1] [b23e151c] [483b9d8c] [425b15ad] [4243657e] [2f5a8663] [00d53c09]
