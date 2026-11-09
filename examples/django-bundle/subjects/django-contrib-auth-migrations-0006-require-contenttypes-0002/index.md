# django/contrib/auth/migrations/0006_require_contenttypes_0002

- Subject: django/contrib/auth/migrations/0006_require_contenttypes_0002 (id `a341a673-339f-4561-90c1-be08e0189f43`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 111 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- operations = [ # Ensure the contenttypes migration is applied before sending # post_migrate signals (which create ContentTypes). ] [66ea4724]
- class Migration(migrations.Migration): dependencies = [ ("auth", "0005_alter_user_last_login_null"), ("contenttypes", "0002_remove_content_type_name"), ] [7cba995b]
- from django.db import migrations [46b663ff]
