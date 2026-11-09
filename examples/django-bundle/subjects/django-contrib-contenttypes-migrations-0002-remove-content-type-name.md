# django/contrib/contenttypes/migrations/0002_remove_content_type_name

- Subject: django/contrib/contenttypes/migrations/0002_remove_content_type_name (id `1c511174-c281-428b-a44c-83c2b2086c6d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 263 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterModelOptions( name="contenttype", options={ "verbose_name": "content type", "verbose_name_plural": "content types", }, ), migrations.AlterField( model_name="contenttype", name="name", field=models.CharField(max_length=100, null=True), ), migrations.RunPython( migrations.RunPython.noop, add_legacy_name, hints={"model_name": "contenttype"}, ), migrations.RemoveField( model_name="contenttype", name="name", ), ] [856f2ebc]
- class Migration(migrations.Migration): dependencies = [ ("contenttypes", "0001_initial"), ] [2e1926d8]
- def add_legacy_name(apps, schema_editor): alias = schema_editor.connection.alias ContentType = apps.get_model("contenttypes", "ContentType") for ct in ContentType.objects.using(alias): try: ct.name = apps.get_model(ct.app_label, ct.model)._meta.object_name except LookupError: ct.name = ct.model ct.save() [dee173d0]
- from django.db import migrations, models [b2ef032411bd05de-8]
