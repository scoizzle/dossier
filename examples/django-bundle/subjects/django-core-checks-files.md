# django/core/checks/files

- Subject: django/core/checks/files (id `08c2c959-26f3-4807-b17c-473b4a38b9d9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 148 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- @register(Tags.files) def check_setting_file_upload_temp_dir(app_configs, **kwargs): setting = getattr(settings, "FILE_UPLOAD_TEMP_DIR", None) if setting and not Path(setting).is_dir(): return [ Error( f"The FILE_UPLOAD_TEMP_DIR setting refers to the nonexistent " f"directory '{setting}'.", id="files.E001", ), ] return [] [395a5e69]
- from . import Error, Tags, register [3d70aaa555e17950-2]
- from django.conf import settings [60c1cf40f51b59b8-2]
- from pathlib import Path [8d8744708e7830c8-2]
