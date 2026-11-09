# Fact 8e3b591c

Store id: 571f914a-a4be-4306-8357-ca3348db5da1

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
- posted_at: `2026-11-09T23:44:50.6595950+00:00`

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
  "id": "571f914a-a4be-4306-8357-ca3348db5da1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6595950+00:00"
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
  "subject_id": "25bfcba9-c3b9-4da5-8171-3701b4a27df2",
  "subject_name": "django/db/models/fields/files::FileField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
