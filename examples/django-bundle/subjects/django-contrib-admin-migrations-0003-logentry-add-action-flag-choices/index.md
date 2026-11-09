# django/contrib/admin/migrations/0003_logentry_add_action_flag_choices

- Subject: django/contrib/admin/migrations/0003_logentry_add_action_flag_choices (id `95c20064-a0f5-4834-8291-3f23add9d4c3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 135 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # No database changes; adds choices to action_flag. operations = [ migrations.AlterField( model_name="logentry", name="action_flag", field=models.PositiveSmallIntegerField( choices=[(1, "Addition"), (2, "Change"), (3, "Deletion")], verbose_name="action flag", ), ), ] [2741f90e]
- class Migration(migrations.Migration): dependencies = [ ("admin", "0002_logentry_remove_auto_add"), ] [daa5b45f]
- from django.db import migrations, models [b2ef032411bd05de]
