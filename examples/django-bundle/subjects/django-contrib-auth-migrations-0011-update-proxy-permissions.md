# django/contrib/auth/migrations/0011_update_proxy_permissions

- Subject: django/contrib/auth/migrations/0011_update_proxy_permissions (id `4dd90c0d-f20c-4fdd-bf61-bc2d149cdc0a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 682 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- Permission(s) for {new} already existed. Codenames Q: {query} [cc2ee481]
- Ensure to audit ALL permissions for {old} and {new}. """ [5dbf1c6f]
- WARNING = """ A problem arose migrating proxy model permissions for {old} to {new}. [48f472ba]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0010_alter_group_name_max_length"), ("contenttypes", "0002_remove_content_type_name"), ] operations = [ migrations.RunPython( update_proxy_model_permissions, revert_proxy_model_permissions ), ] [c8f575eb]
- def revert_proxy_model_permissions(apps, schema_editor): """ Update the content_type of proxy model permissions to use the ContentType of the concrete model. """ update_proxy_model_permissions(apps, schema_editor, reverse=True) [d5d30580]
- def update_proxy_model_permissions(apps, schema_editor, reverse=False): """ Update the content_type of proxy model permissions to use the ContentType of the proxy model. """ style = color_style() Permission = apps.get_model("auth", "Permission") ContentType = apps.get_model("contenttypes", "ContentType") alias = schema_editor.connection.alias for Model in apps.get_models(): opts = Model._meta if not opts.proxy: continue proxy_default_permissions_codenames = [ "%s_%s" % (action, opts.model_name) for action in opts.default_permissions ] permissions_query = Q(codename__in=proxy_default_permissions_codenames) for codename, name in opts.permissions: permissions_query |= Q(codename=codename, name=name) content_type_manager = ContentType.objects.db_manager(alias) concrete_content_type = content_type_manager.get_for_model( Model, for_concrete_model=True ) proxy_content_type = content_type_manager.get_for_model( Model, for_concrete_model=False ) old_content_type = proxy_content_type if reverse else concrete_content_type new_content_type = concrete_content_type if reverse else proxy_content_type try: with transaction.atomic(using=alias): Permission.objects.using(alias).filter( permissions_query, content_type=old_content_type, ).update(content_type=new_content_type) except IntegrityError: old = "{}_{}".format(old_content_type.app_label, old_content_type.model) new = "{}_{}".format(new_content_type.app_label, new_content_type.model) sys.stdout.write( style.WARNING(WARNING.format(old=old, new=new, query=permissions_query)) ) [c066cd2a]
- from django.core.management.color import color_style from django.db import IntegrityError, migrations, transaction from django.db.models import Q [44bc8db3]
- import sys [6b0cb2be5ea1bc3c]
