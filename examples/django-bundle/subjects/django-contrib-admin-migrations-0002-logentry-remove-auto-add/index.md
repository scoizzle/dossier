# django/contrib/admin/migrations/0002_logentry_remove_auto_add

- Subject: django/contrib/admin/migrations/0002_logentry_remove_auto_add (id `5ba82a25-a016-49f8-a860-8733ace599ac`)
- Kind: subject
- Budget: 1200 tokens
- Used: 134 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # No database changes; removes auto_add and adds default/editable. operations = [ migrations.AlterField( model_name="logentry", name="action_time", field=models.DateTimeField( verbose_name="action time", default=timezone.now, editable=False, ), ), ] [45f58886]
- class Migration(migrations.Migration): dependencies = [ ("admin", "0001_initial"), ] [c163db21]
- from django.db import migrations, models from django.utils import timezone [ace7f90f]
