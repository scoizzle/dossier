# Fact 5282e7cd

Store id: f0d16dfb-fd4c-4bf5-b850-ddbbb372aa9f

## Text

```text
def _check_db_collation(self, databases)
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
- posted_at: `2026-11-09T23:31:56.7972820+00:00`

## Data

```json
{
  "end_line": 2558,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2538,
  "symbol": "TextField._check_db_collation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2538,"selector":"L2538-L2558","symbol":"TextField._check_db_collation"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField._check_db_collation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2558,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2538,
    "symbol": "TextField._check_db_collation"
  },
  "id": "f0d16dfb-fd4c-4bf5-b850-ddbbb372aa9f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7972820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2538,
        "selector": "L2538-L2558",
        "symbol": "TextField._check_db_collation"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c5825199-1fcc-443c-b1c1-0e426f58edda",
  "subject_name": "django/db/models/fields/__init__::TextField._check_db_collation",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_db_collation(self, databases)"
}
```
