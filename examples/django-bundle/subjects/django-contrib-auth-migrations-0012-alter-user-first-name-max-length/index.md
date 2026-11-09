# django/contrib/auth/migrations/0012_alter_user_first_name_max_length

- Subject: django/contrib/auth/migrations/0012_alter_user_first_name_max_length (id `2b873e27-0710-4bbf-b6dd-e8f599ed6144`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 108 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="user", name="first_name", field=models.CharField( blank=True, max_length=150, verbose_name="first name" ), ), ] [fc11a97c]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0011_update_proxy_permissions"), ] [7c05528a]
- from django.db import migrations, models [b2ef032411bd05de-7]
