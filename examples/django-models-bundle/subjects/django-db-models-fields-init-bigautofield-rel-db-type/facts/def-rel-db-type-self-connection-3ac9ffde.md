# Fact 3ac9ffde

Store id: ca0564cf-9a83-4874-8362-6f82526ec3c9

## Text

```text
def rel_db_type(self, connection)
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
- posted_at: `2026-11-09T23:31:56.9297030+00:00`

## Data

```json
{
  "end_line": 2976,
  "entity_kind": "method",
  "parent": "BigAutoField",
  "start_line": 2975,
  "symbol": "BigAutoField.rel_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2975,"selector":"L2975-L2976","symbol":"BigAutoField.rel_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigAutoField.rel_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2976,
    "entity_kind": "method",
    "parent": "BigAutoField",
    "start_line": 2975,
    "symbol": "BigAutoField.rel_db_type"
  },
  "id": "ca0564cf-9a83-4874-8362-6f82526ec3c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9297030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2975,
        "selector": "L2975-L2976",
        "symbol": "BigAutoField.rel_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9169b53f-2bae-44ac-9d47-8397ff7dd622",
  "subject_name": "django/db/models/fields/__init__::BigAutoField.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
