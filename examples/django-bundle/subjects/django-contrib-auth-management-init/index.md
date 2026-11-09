# django/contrib/auth/management/__init__

- Subject: django/contrib/auth/management/__init__ (id `015be3e1-1fed-4ef5-ad2b-2fd9b9db899f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2451 tokens
- Facts shown: 37 of 37
- Conflicts: 0
- Gaps: 0

## Highlights

- perm = codenames.get(old_codename) if perm is None: continue if codenames.get(new_codename, perm) is not perm: conflicts.append((perm.pk, old_codename, new_codename)) continue [99de6e71]
- planned.append((perm, old_codename, new_codename, new_name_str)) [97eef77e]
- actions, verbose_name_raw = _get_permission_metadata( apps, app_label, final_names[new_name] ) for action in actions: old_codename = f"{action}_{old_name}" new_codename = f"{action}_{new_name}" new_name_str = f"Can {action} {verbose_name_raw}" [fd86eaf7]
- # Collapse chains of renames (e.g. A -> B -> C) into one rename per model # (A -> C). post_migrate runs after every RenameContentType operation, so # each content type is already stored under the model's final name. original_names = {} for old_name, new_name in renames: old_name, new_name = old_name.lower(), new_name.lower() original_names[new_name] = original_names.pop(old_name, old_name) # Final model names as written in the migrations, for the permission names. final_names = {new_name.lower(): new_name for _, new_name in renames} [673fbbe1]
- # Collect (from_model, to_model) pairs renames = [] for migration, backward in plan or []: if migration.app_label != app_label: continue operations = migration.operations if backward: operations = reversed(operations) for op in operations: if not isinstance(op, migrations.RenameModel): continue if backward: renames.append((op.new_name, op.old_name)) else: renames.append((op.old_name, op.new_name)) [a5f916db]
- # Don't return the default username if it is already taken. if check_db and default_username: try: auth_app.User._default_manager.db_manager(database).get( username=default_username, ) except auth_app.User.DoesNotExist: pass else: return "" return default_username [dec4a137]
- # Ensure that contenttypes are created for this app. Needed if # 'django.contrib.auth' is in INSTALLED_APPS before # 'django.contrib.contenttypes'. create_contenttypes( app_config, verbosity=verbosity, interactive=interactive, using=using, apps=apps, **kwargs, ) [0f502d5a]
- # Find all the Permissions that have a content_type for a model we're # looking for. We don't need to check for codenames since we already have # a list of the ones we're going to create. all_perms = set( Permission.objects.using(using) .filter( content_type__in=set(ctypes.values()), ) .values_list("content_type", "codename") ) [6a4b5e1d]
- # Grab all the ContentTypes. ctypes = ContentType.objects.db_manager(using).get_for_models( *models, for_concrete_models=False ) [5c3c115b]
- # If the User model has been swapped out, we can't make any assumptions # about the default user name. if auth_app.User._meta.swapped: return "" [3389353f]
- # Raise error if conflicts found if conflicts: if verbosity: style = color_style() for pk, old, new in conflicts: msg = ( f"Failed to rename permission {pk} from '{old}' to '{new}'. " f"Please resolve the conflict manually.\n" ) stdout.write(style.WARNING(msg)) error_message = f"{len(conflicts)} permission rename conflict(s) detected." raise RuntimeError(error_message) [1d8330e7]
- # Run the username validator try: auth_app.User._meta.get_field("username").run_validators(default_username) except exceptions.ValidationError: return "" [d6507ccd]

## All facts

- [fe0e97ff] # This handler is connected to the global post_migrate signal, which is # emitted for *all* apps — including test configurations where # django.contrib.auth is NOT installed. try: Permission = apps.get_model("auth", "Permission") ContentType = apps.get_model("contenttypes", "ContentType") except LookupError: return db = using or router.db_for_write(Permission) if not router.allow_migrate_model(db, Permission): return
- [210dd833] :param check_db: If ``True``, requires that the username does not match an existing ``auth.User`` (otherwise returns an empty string). :param database: The database where the unique check will be performed. :returns: The username, or an empty string if no username can be determined or the suggested username is already taken. """ # This file is used in apps.py, it should not trigger models import. from django.contrib.auth import models as auth_app
- [3df8f47a] Permission.objects.using(using).bulk_create(perms) if verbosity >= 2: for perm in perms: print("Adding permission '%s'" % perm)
- [cb25c60b] app_label = app_config.label
- [60ee6d19] app_label = app_config.label try: app_config = apps.get_app_config(app_label) ContentType = apps.get_model("contenttypes", "ContentType") except LookupError: return
- [3d3a607f] content_types = ( ContentType.objects.using(db) .filter(app_label=app_label, model__in=original_names.keys()) .prefetch_related("permission_set") ) perms_by_model = { ct.model: {perm.codename: perm for perm in ct.permission_set.all()} for ct in content_types }
- [d6f0da96] default_username = get_system_username() try: default_username = ( unicodedata.normalize("NFKD", default_username) .encode("ascii", "ignore") .decode("ascii") .replace(" ", "") .lower() ) except UnicodeDecodeError: return ""
- [3cf06683] for _, from_codename, to_codename, _ in planned: if verbosity >= 2: stdout.write( f"Renamed permission(s): " f"{app_label}.{from_codename} → {to_codename}\n" )
- [65f4e87b] for new_name, old_name in original_names.items(): codenames = perms_by_model.get(new_name) if codenames is None: # Perhaps RenameContentType aborted due to a conflict? continue
- [efc55b95] if not renames: return
- [9492e870] models = list(app_config.get_models())
- [02b48633] perms = [] for model in models: ctype = ctypes[model] for codename, name in _get_all_permissions(model._meta): if (ctype.pk, codename) not in all_perms: permission = Permission() permission._state.db = using permission.codename = codename permission.name = name permission.content_type = ctype perms.append(permission)
- [2ec3341f] planned = [] conflicts = []
- [0eee79ce] try: Permission = apps.get_model("auth", "Permission") except LookupError: return if not router.allow_migrate_model(using, Permission): return
- [52688326] with transaction.atomic(using=db): for perm, _, new_codename, new_name_str in planned: perm.codename = new_codename perm.name = new_name_str perm.save(update_fields={"codename", "name"}, using=db)
- [a3efc5c5] """ Creates permissions for all installed apps that need permissions, and renames them on model renames. """
- [07b11986] def _get_all_permissions(opts): """ Return (codename, name) for all permissions in the given opts. """ return [*_get_builtin_permissions(opts), *opts.permissions]
- [a90d2f24] def _get_builtin_permissions(opts): """ Return (codename, name) for all autogenerated permissions. By default, this is ('add', 'change', 'delete', 'view') """ perms = [] for action in opts.default_permissions: perms.append( ( get_permission_codename(action, opts), "Can %s %s" % (action, opts.verbose_name_raw), ) ) return perms
- [2fef8384] def _get_permission_metadata(apps, app_label, model_name): try: model = apps.get_model(app_label, model_name) except LookupError: # Model does not exist in this migration state, e.g. zero. Permission = apps.get_model("auth", "Permission") return Permission._meta.default_permissions, model_name return ( model._meta.default_permissions, model._meta.verbose_name_raw, )
- [ca1e1a61] def create_permissions( app_config, verbosity=2, interactive=True, using=DEFAULT_DB_ALIAS, apps=global_apps, **kwargs, ): if not app_config.models_module: return
- [07de8074] def get_default_username(check_db=True, database=DEFAULT_DB_ALIAS): """ Try to determine the current system user's username to use as a default.
- [0c7cba92] def get_system_username(): """ Return the current system user's username, or an empty string if the username could not be determined. """ try: result = getpass.getuser() except (ImportError, KeyError, OSError): # TODO: Drop ImportError and KeyError when dropping support for PY312. # KeyError (Python <3.13) or OSError (Python 3.13+) will be raised by # os.getpwuid() (called by getuser()) if there is no corresponding # entry in the /etc/passwd file (for example, in a very restricted # chroot environment). return "" return result
- [3b5d81ff] def rename_permissions_after_model_rename( app_config, verbosity=2, plan=None, using=DEFAULT_DB_ALIAS, apps=global_apps, stdout=sys.stdout, **kwargs, ): if not app_config.models_module: return
- [f9c5025e] from django.apps import apps as global_apps from django.contrib.auth import get_permission_codename from django.contrib.contenttypes.management import create_contenttypes from django.core import exceptions from django.core.management.color import color_style from django.db import DEFAULT_DB_ALIAS, migrations, router, transaction
- [690659b4] import getpass import sys import unicodedata
