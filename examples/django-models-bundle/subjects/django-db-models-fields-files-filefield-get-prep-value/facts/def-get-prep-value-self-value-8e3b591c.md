# Fact 8e3b591c

Store id: e348a06d-54bf-4697-ba2f-35e52d88e557

## Text

```text
def get_prep_value(self, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.4023080+00:00`

## Data

```json
{
  "end_line": 326,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 320,
  "symbol": "FileField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":320,"selector":"L320-L326","symbol":"FileField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 326,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 320,
    "symbol": "FileField.get_prep_value"
  },
  "id": "e348a06d-54bf-4697-ba2f-35e52d88e557",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4023080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 320,
        "selector": "L320-L326",
        "symbol": "FileField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "352296e2-fdc8-4e9f-bd09-6b00e7ea7e68",
  "subject_name": "django/db/models/fields/files::FileField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
