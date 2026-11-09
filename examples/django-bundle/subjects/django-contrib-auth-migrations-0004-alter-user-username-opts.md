# django/contrib/auth/migrations/0004_alter_user_username_opts

- Subject: django/contrib/auth/migrations/0004_alter_user_username_opts (id `8bc33914-f7d8-44ef-866c-08d40da4974e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 191 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # No database changes; modifies validators and error_messages (#13147). operations = [ migrations.AlterField( model_name="user", name="username", field=models.CharField( error_messages={"unique": "A user with that username already exists."}, max_length=30, validators=[validators.UnicodeUsernameValidator()], help_text=( "Required. 30 characters or fewer. Letters, digits and @/./+/-/_ " "only." ), unique=True, verbose_name="username", ), ), ] [a18a9a68]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0003_alter_user_email_max_length"), ] [a7ffa8f9]
- from django.contrib.auth import validators from django.db import migrations, models [95f632b04cf7fe2b]
