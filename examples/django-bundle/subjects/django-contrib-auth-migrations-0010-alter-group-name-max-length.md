# django/contrib/auth/migrations/0010_alter_group_name_max_length

- Subject: django/contrib/auth/migrations/0010_alter_group_name_max_length (id `9196ab76-5cd2-41c4-ad7f-08792fa06451`)
- Kind: subject
- Budget: 1200 tokens
- Used: 107 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="group", name="name", field=models.CharField(max_length=150, unique=True, verbose_name="name"), ), ] [cd2a00ff]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0009_alter_user_last_name_max_length"), ] [6f05b3f3]
- from django.db import migrations, models [b2ef032411bd05de-6]
