# django/contrib/contenttypes/management/__init__

- Subject: django/contrib/contenttypes/management/__init__ (id `b30fa5e9-3fbd-4972-a721-e785ef81482e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1171 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Highlights

- try: content_type = ContentType.objects.db_manager(db).get_by_natural_key( self.app_label, old_model ) except ContentType.DoesNotExist: pass else: content_type.model = new_model try: with transaction.atomic(using=db): content_type.save(using=db, update_fields={"model"}) except IntegrityError: # Gracefully fallback if a stale content type causes a # conflict. Warn the user so they can run the # remove_stale_contenttypes management command. warnings.warn( f"Could not rename content type '{self.app_label}.{old_model}' " f"to '{new_model}' due to an existing conflicting content type. " "Run 'remove_stale_contenttypes' to clean up stale entries.", RuntimeWarning, ) content_type.model = old_model else: # Clear the cache as the `get_by_natural_key()` call will cache # the renamed ContentType instance by its old model name. ContentType.objects.clear_cache() [4161609b]
- # Determine whether or not the ContentType model is available. try: ContentType = apps.get_model("contenttypes", "ContentType") except LookupError: available = False else: if not router.allow_migrate_model(using, ContentType): return available = True [c3a6019a]
- ContentType.objects.clear_cache() [46c34cd6]
- all_model_names = {model._meta.model_name for model in app_config.get_models()} [12e5e5ac]
- cts = [ ContentType(app_label=app_config.label, model=model_name) for model_name in sorted(all_model_names - existing_model_names) ] ContentType.objects.using(using).bulk_create(cts) if verbosity >= 2: for ct in cts: print(f"Adding content type '{ct.app_label} | {ct.model}'") [7ba8e3ba]
- def _rename(self, apps, schema_editor, old_model, new_model): ContentType = apps.get_model("contenttypes", "ContentType") db = schema_editor.connection.alias if not router.allow_migrate_model(db, ContentType): return [dca81014]
- def rename_backward(self, apps, schema_editor): self._rename(apps, schema_editor, self.new_model, self.old_model) [b2da7d1a]
- def rename_forward(self, apps, schema_editor): self._rename(apps, schema_editor, self.old_model, self.new_model) [ebd24438]
- existing_model_names = set( ContentType.objects.using(using) .filter(app_label=app_config.label) .values_list("model", flat=True) ) [fb339c73]
- for migration, backward in plan: if (migration.app_label, migration.name) == ("contenttypes", "0001_initial"): # There's no point in going forward if the initial contenttypes # migration is unapplied as the ContentType model will be # unavailable from this point. if backward: break else: available = True continue # The ContentType model is not available yet. if not available: continue inserts = [] for index, operation in enumerate(migration.operations): if isinstance(operation, migrations.RenameModel): operation = RenameContentType( migration.app_label, operation.old_name_lower, operation.new_name_lower, ) inserts.append((index + 1, operation)) for inserted, (index, operation) in enumerate(inserts): migration.operations.insert(inserted + index, operation) [6874913c]
- if not all_model_names: return [ee0e5a1b]
- if not router.allow_migrate_model(using, ContentType): return [695ce3cc]
- import warnings [a7aa58d143dc3945]

## All facts

- [7d58cfd1] try: app_config = apps.get_app_config(app_config.label) ContentType = apps.get_model("contenttypes", "ContentType") except LookupError: return
- [88cab374] class RenameContentType(migrations.RunPython): def __init__(self, app_label, old_model, new_model): self.app_label = app_label self.old_model = old_model self.new_model = new_model super().__init__(self.rename_forward, self.rename_backward)
- [d1705e25] def create_contenttypes( app_config, verbosity=2, interactive=True, using=DEFAULT_DB_ALIAS, apps=global_apps, **kwargs, ): """ Create content types for models in the given app. """ if not app_config.models_module: return
- [9a90f8ed] def inject_rename_contenttypes_operations( plan=None, apps=global_apps, using=DEFAULT_DB_ALIAS, **kwargs ): """ Insert a `RenameContentType` operation after every planned `RenameModel` operation. """ if plan is None: return
- [abeebce0] from django.apps import apps as global_apps from django.db import DEFAULT_DB_ALIAS, IntegrityError, migrations, router, transaction
