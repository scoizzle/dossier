# django/contrib/auth/migrations/0005_alter_user_last_login_null

- Subject: django/contrib/auth/migrations/0005_alter_user_last_login_null (id `1d5e61e4-6074-41ea-87ba-2d9c08188da0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 108 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="user", name="last_login", field=models.DateTimeField( null=True, verbose_name="last login", blank=True ), ), ] [0b2b3b36]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0004_alter_user_username_opts"), ] [63e4fb0d]
- from django.db import migrations, models [b2ef032411bd05de-4]
