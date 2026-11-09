# Fact 0b5bc6e0

Store id: 5363fefa-d647-4b99-bba3-404aa3a3a829

## Text

```text
def prepare_database_save(self, field)
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
- posted_at: `2026-11-09T22:39:40.3470250+00:00`

## Data

```json
{
  "end_line": 1448,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1443,
  "symbol": "Model.prepare_database_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1443,"selector":"L1443-L1448","symbol":"Model.prepare_database_save"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.prepare_database_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1448,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1443,
    "symbol": "Model.prepare_database_save"
  },
  "id": "5363fefa-d647-4b99-bba3-404aa3a3a829",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3470250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1443,
        "selector": "L1443-L1448",
        "symbol": "Model.prepare_database_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "ff38863d-297a-4c02-8c91-ffcd565f2513",
  "subject_name": "django/db/models/base::Model.prepare_database_save",
  "tags": [
    "entity:method"
  ],
  "text": "def prepare_database_save(self, field)"
}
```
