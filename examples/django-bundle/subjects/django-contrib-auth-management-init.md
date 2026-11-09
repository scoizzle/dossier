# django/contrib/auth/management/__init__

- Subject: django/contrib/auth/management/__init__ (id `0574d3d8-3b7c-4924-b02a-55daf54bc4a5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 12 of 37
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

25 more facts did not fit in the budget: [fe0e97ff] [210dd833] [3df8f47a] [cb25c60b] [60ee6d19] [3d3a607f] [d6f0da96] [3cf06683] [65f4e87b] [efc55b95] [9492e870] [02b48633] [2ec3341f] [0eee79ce] [52688326] [a3efc5c5] [07b11986] [a90d2f24] [2fef8384] [ca1e1a61] [07de8074] [0c7cba92] [3b5d81ff] [f9c5025e] [690659b4]
