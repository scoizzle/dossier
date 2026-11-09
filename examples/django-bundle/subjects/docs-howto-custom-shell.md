# docs/howto/custom-shell

- Subject: docs/howto/custom-shell (id `9ea136a6-ae79-4969-adac-9362adfe192f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 19 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- from django.db import connection, reset_queries, models from django.conf import settings from django.contrib.admin.models import LogEntry from django.contrib.auth.models import Group, Permission, User from django.contrib.contenttypes.models import ContentType from django.contrib.sessions.models import Session from django.urls import resolve, reverse from django.utils import timezone [5d3fc452]
- 13 objects imported automatically: [7bd73a14]
- Automatic imports of common utilities, such as ``django.conf.settings``, were added. [8be28e1368108f1c]
- class Command(shell.Command): def get_auto_imports(self): return None [7a27735a]
- class Command(shell.Command): def get_auto_imports(self): return super().get_auto_imports() + [ "django.urls.reverse", "django.urls.resolve", ] [a172f00c]
- from django.core.management.commands import shell [564a7207]
- .. _customizing-shell-auto-imports: [73203dcc]
- .. code-block:: python :caption: ``polls/management/commands/shell.py`` [c06ebbe5]
- .. console:: [7714e199aac2701e]
- .. versionchanged:: 6.0 [57739e32d87f6c76]
- ====================================== How to customize the ``shell`` command ====================================== [f6eb48a4]
- Customize automatic imports =========================== [369ebd61]
- Customizing the :djadmin:`shell` command allows adding extra functionality or pre-loading specific modules. To do this, create a new management command that subclasses ``django.core.management.commands.shell.Command`` and overrides the existing ``shell`` management command. For more details, refer to the guide on :ref:`overriding commands <overriding-commands>`. [93f5dd9a]
- If an overridden ``shell`` command includes paths that cannot be imported, these errors are shown when ``verbosity`` is set to ``1`` or higher. Duplicate imports are automatically handled. [231efd20]
- Note that automatic imports can be disabled for a specific ``shell`` session using the :option:`--no-imports <shell --no-imports>` flag. To permanently disable automatic imports, override ``get_auto_imports()`` to return ``None``:: [9af9ebc1]
- Running this customized ``shell`` command with ``verbosity=2`` would show: [126e80e4]
- The Django :djadmin:`shell` is an interactive Python environment that provides access to models and settings, making it useful for testing code, experimenting with queries, and interacting with application data. [66d9ffb1]
- The customization above adds :func:`~django.urls.resolve` and :func:`~django.urls.reverse` to the default namespace, which already includes all models from the apps listed in :setting:`INSTALLED_APPS` plus what is imported by default. These objects will be available in the ``shell`` without requiring a manual import. [fba587f9]
- To customize the automatic import behavior of the :djadmin:`shell` management command, override the ``get_auto_imports()`` method. This method should return a sequence of import paths for objects or modules available in the application. For example: [ebbb7bfc]
