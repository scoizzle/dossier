# django/core/files/storage/mixins

- Subject: django/core/files/storage/mixins (id `4d15d10b-dc15-442f-bc37-fbdc027628ec`)
- Kind: subject
- Budget: 1200 tokens
- Used: 167 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- def _value_or_setting(self, value, setting): return setting if value is None else value [ba986125]
- class StorageSettingsMixin: def _clear_cached_properties(self, setting, **kwargs): """Reset setting based property values.""" if setting == "MEDIA_ROOT": self.__dict__.pop("base_location", None) self.__dict__.pop("location", None) elif setting == "MEDIA_URL": self.__dict__.pop("base_url", None) elif setting == "FILE_UPLOAD_PERMISSIONS": self.__dict__.pop("file_permissions_mode", None) elif setting == "FILE_UPLOAD_DIRECTORY_PERMISSIONS": self.__dict__.pop("directory_permissions_mode", None) [cf110bac]
