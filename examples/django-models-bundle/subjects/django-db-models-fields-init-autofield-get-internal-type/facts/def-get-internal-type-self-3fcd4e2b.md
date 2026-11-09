# Fact 3fcd4e2b

Store id: bc9c8f64-e73e-4d08-b79f-19611634175e

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.3360790+00:00`

## Data

```json
{
  "end_line": 2965,
  "entity_kind": "method",
  "parent": "AutoField",
  "start_line": 2964,
  "symbol": "AutoField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2964,"selector":"L2964-L2965","symbol":"AutoField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2965,
    "entity_kind": "method",
    "parent": "AutoField",
    "start_line": 2964,
    "symbol": "AutoField.get_internal_type"
  },
  "id": "bc9c8f64-e73e-4d08-b79f-19611634175e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3360790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2964,
        "selector": "L2964-L2965",
        "symbol": "AutoField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "743d8f01-32e9-4021-b0ce-d4c4f116cc73",
  "subject_name": "django/db/models/fields/__init__::AutoField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
