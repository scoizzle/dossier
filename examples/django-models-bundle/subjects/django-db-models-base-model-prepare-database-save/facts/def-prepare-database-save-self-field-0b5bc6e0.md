# Fact 0b5bc6e0

Store id: 66712558-f994-47fe-bb33-c3100b096d60

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
- posted_at: `2026-11-09T23:31:53.7535370+00:00`

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
  "id": "66712558-f994-47fe-bb33-c3100b096d60",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7535370+00:00"
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
  "subject_id": "50347feb-83c8-4098-9498-8401524c42de",
  "subject_name": "django/db/models/base::Model.prepare_database_save",
  "tags": [
    "entity:method"
  ],
  "text": "def prepare_database_save(self, field)"
}
```
