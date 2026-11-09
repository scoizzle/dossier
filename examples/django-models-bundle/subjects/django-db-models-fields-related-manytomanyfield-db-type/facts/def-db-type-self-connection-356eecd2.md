# Fact 356eecd2

Store id: 25ec3580-4eb3-4bb7-84b4-ff4ffd3e1338

## Text

```text
def db_type(self, connection)
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
- posted_at: `2026-11-09T23:31:58.9062050+00:00`

## Data

```json
{
  "end_line": 2209,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2206,
  "symbol": "ManyToManyField.db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2206,"selector":"L2206-L2209","symbol":"ManyToManyField.db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2209,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2206,
    "symbol": "ManyToManyField.db_type"
  },
  "id": "25ec3580-4eb3-4bb7-84b4-ff4ffd3e1338",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.9062050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2206,
        "selector": "L2206-L2209",
        "symbol": "ManyToManyField.db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "66350ac1-1e7b-402f-8684-f02197cafa7d",
  "subject_name": "django/db/models/fields/related::ManyToManyField.db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type(self, connection)"
}
```
