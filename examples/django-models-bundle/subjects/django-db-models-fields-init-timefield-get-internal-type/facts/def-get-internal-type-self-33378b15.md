# Fact 33378b15

Store id: eb973705-f19e-4b40-bd77-05cfe3f8bdd7

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
- posted_at: `2026-11-09T23:31:56.8190940+00:00`

## Data

```json
{
  "end_line": 2658,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2657,
  "symbol": "TimeField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2657,"selector":"L2657-L2658","symbol":"TimeField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2658,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2657,
    "symbol": "TimeField.get_internal_type"
  },
  "id": "eb973705-f19e-4b40-bd77-05cfe3f8bdd7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8190940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2657,
        "selector": "L2657-L2658",
        "symbol": "TimeField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e44e4fa8-0e8a-42c4-bb42-bdb54b7a4733",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
