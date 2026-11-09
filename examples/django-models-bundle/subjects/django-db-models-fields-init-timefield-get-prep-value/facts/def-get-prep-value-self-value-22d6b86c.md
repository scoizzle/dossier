# Fact 22d6b86c

Store id: f77aaa83-92d1-4c74-b2da-c8b0f231478c

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T22:39:42.6713540+00:00`

## Data

```json
{
  "end_line": 2698,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2696,
  "symbol": "TimeField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2696,"selector":"L2696-L2698","symbol":"TimeField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2698,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2696,
    "symbol": "TimeField.get_prep_value"
  },
  "id": "f77aaa83-92d1-4c74-b2da-c8b0f231478c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6713540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2696,
        "selector": "L2696-L2698",
        "symbol": "TimeField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9471ac3a-36c6-4254-855b-1f7c9dbcccca",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
