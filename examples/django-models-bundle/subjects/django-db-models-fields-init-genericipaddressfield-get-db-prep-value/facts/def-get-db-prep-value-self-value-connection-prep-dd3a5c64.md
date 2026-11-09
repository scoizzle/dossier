# Fact dd3a5c64

Store id: d51801b1-0430-496f-9107-c0a559df31ef

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
- posted_at: `2026-11-09T22:39:42.5847260+00:00`

## Data

```json
{
  "end_line": 2364,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2361,
  "symbol": "GenericIPAddressField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2361,"selector":"L2361-L2364","symbol":"GenericIPAddressField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2364,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2361,
    "symbol": "GenericIPAddressField.get_db_prep_value"
  },
  "id": "d51801b1-0430-496f-9107-c0a559df31ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5847260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2361,
        "selector": "L2361-L2364",
        "symbol": "GenericIPAddressField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fcc88b2a-b19d-4043-9094-8d1d6243ade9",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
