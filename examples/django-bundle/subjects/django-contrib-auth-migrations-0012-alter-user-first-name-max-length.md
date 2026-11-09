# django/contrib/auth/migrations/0012_alter_user_first_name_max_length

- Subject: django/contrib/auth/migrations/0012_alter_user_first_name_max_length (id `d66eadd1-d39f-4e44-a1c6-3023539195b5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 108 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="user", name="first_name", field=models.CharField( blank=True, max_length=150, verbose_name="first name" ), ), ] [fc11a97c]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0011_update_proxy_permissions"), ] [7c05528a]
- from django.db import migrations, models [b2ef032411bd05de-7]
