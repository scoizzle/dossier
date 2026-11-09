# Fact a0dce115

Store id: c7ca5abc-ff4c-4873-b78a-6e260f166b95

## Text

```text
def get_db_prep_value(self, value, connection, prepared=False)
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
- posted_at: `2026-11-09T22:39:42.4382830+00:00`

## Data

```json
{
  "end_line": 1725,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1721,
  "symbol": "DateTimeField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1721,"selector":"L1721-L1725","symbol":"DateTimeField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1725,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1721,
    "symbol": "DateTimeField.get_db_prep_value"
  },
  "id": "c7ca5abc-ff4c-4873-b78a-6e260f166b95",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4382830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1721,
        "selector": "L1721-L1725",
        "symbol": "DateTimeField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "085c83d1-c921-40e0-9ad2-785245aa2add",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
