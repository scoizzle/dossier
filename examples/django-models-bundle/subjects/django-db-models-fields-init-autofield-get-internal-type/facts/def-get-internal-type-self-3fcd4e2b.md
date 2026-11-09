# Fact 3fcd4e2b

Store id: bef377d0-9d3e-41af-9bbc-cd05af406b4c

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
- posted_at: `2026-11-09T23:31:56.9217070+00:00`

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
  "id": "bef377d0-9d3e-41af-9bbc-cd05af406b4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9217070+00:00"
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
  "subject_id": "9d5e6a80-f9c1-41ca-9dfd-632814b88157",
  "subject_name": "django/db/models/fields/__init__::AutoField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
