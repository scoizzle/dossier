# django/contrib/auth/migrations/0008_alter_user_username_max_length

- Subject: django/contrib/auth/migrations/0008_alter_user_username_max_length (id `fa697041-dd82-4926-b491-efe0c70d6a13`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 175 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ migrations.AlterField( model_name="user", name="username", field=models.CharField( error_messages={"unique": "A user with that username already exists."}, help_text=( "Required. 150 characters or fewer. Letters, digits and @/./+/-/_ " "only." ), max_length=150, unique=True, validators=[validators.UnicodeUsernameValidator()], verbose_name="username", ), ), ] [a33e3d1e]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0007_alter_validators_add_error_messages"), ] [6bc076b1]
- from django.contrib.auth import validators from django.db import migrations, models [95f632b04cf7fe2b-3]
