# Fact 8a0176be

Store id: 344426ed-b91c-4633-833d-725fe04d247e

## Text

```text
def cast_db_type(self, connection)
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
- posted_at: `2026-11-09T23:44:51.6051040+00:00`

## Data

```json
{
  "end_line": 1320,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1319,
  "symbol": "ForeignKey.cast_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1319,"selector":"L1319-L1320","symbol":"ForeignKey.cast_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.cast_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1320,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1319,
    "symbol": "ForeignKey.cast_db_type"
  },
  "id": "344426ed-b91c-4633-833d-725fe04d247e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6051040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1319,
        "selector": "L1319-L1320",
        "symbol": "ForeignKey.cast_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "b5648bff-f8f3-4225-9f9d-e0c4981c938e",
  "subject_name": "django/db/models/fields/related::ForeignKey.cast_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def cast_db_type(self, connection)"
}
```
