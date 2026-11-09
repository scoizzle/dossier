# django/contrib/contenttypes/migrations/0001_initial

- Subject: django/contrib/contenttypes/migrations/0001_initial (id `09b9912d-5b51-429a-b042-418dd69a58ab`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 244 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.CreateModel( name="ContentType", fields=[ ( "id", models.AutoField( verbose_name="ID", serialize=False, auto_created=True, primary_key=True, ), ), ("name", models.CharField(max_length=100)), ("app_label", models.CharField(max_length=100)), ( "model", models.CharField( max_length=100, verbose_name="python model class name" ), ), ], options={ "ordering": ("name",), "db_table": "django_content_type", "verbose_name": "content type", "verbose_name_plural": "content types", }, bases=(models.Model,), managers=[ ("objects", django.contrib.contenttypes.models.ContentTypeManager()), ], ), migrations.AlterUniqueTogether( name="contenttype", unique_together={("app_label", "model")}, ), ] [44f91520]
- class Migration(migrations.Migration): dependencies = [] [25db17bb852de530]
- import django.contrib.contenttypes.models from django.db import migrations, models [a23e1c08]
