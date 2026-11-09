# Fact dcff097d

Store id: 07715606-e869-4de3-829f-63e097886715

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:54.1146680+00:00`

## Data

```json
{
  "end_line": 230,
  "entity_kind": "method",
  "parent": "Ord",
  "start_line": 229,
  "symbol": "Ord.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":229,"selector":"L229-L230","symbol":"Ord.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Ord.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 230,
    "entity_kind": "method",
    "parent": "Ord",
    "start_line": 229,
    "symbol": "Ord.as_sqlite"
  },
  "id": "07715606-e869-4de3-829f-63e097886715",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1146680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 229,
        "selector": "L229-L230",
        "symbol": "Ord.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "5bfdd23e-4188-4fbf-914a-7e68d6f1fc5f",
  "subject_name": "django/db/models/functions/text::Ord.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
