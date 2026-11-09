# django/contrib/auth/migrations/0002_alter_permission_name_max_length

- Subject: django/contrib/auth/migrations/0002_alter_permission_name_max_length (id `7b006f8d-97f3-403a-abbd-1030161109c0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 99 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="permission", name="name", field=models.CharField(max_length=255, verbose_name="name"), ), ] [7f902d32]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0001_initial"), ] [0f57f291]
- from django.db import migrations, models [b2ef032411bd05de-2]
