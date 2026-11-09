# Fact 0a198fb5

Store id: 3617243a-6256-4c6d-b327-6d4ce33a4f12

## Text

```text
def db_check(self, connection)
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
- posted_at: `2026-11-09T22:39:44.4102200+00:00`

## Data

```json
{
  "end_line": 1314,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1313,
  "symbol": "ForeignKey.db_check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1313,"selector":"L1313-L1314","symbol":"ForeignKey.db_check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.db_check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1314,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1313,
    "symbol": "ForeignKey.db_check"
  },
  "id": "3617243a-6256-4c6d-b327-6d4ce33a4f12",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4102200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1313,
        "selector": "L1313-L1314",
        "symbol": "ForeignKey.db_check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e8aa4a36-df30-4a24-8b88-a5ad34a89948",
  "subject_name": "django/db/models/fields/related::ForeignKey.db_check",
  "tags": [
    "entity:method"
  ],
  "text": "def db_check(self, connection)"
}
```
