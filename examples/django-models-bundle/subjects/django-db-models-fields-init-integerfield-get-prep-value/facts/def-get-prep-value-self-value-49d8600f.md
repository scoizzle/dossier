# Fact 49d8600f

Store id: 2a4e361a-1932-4ca6-8f84-8411f0a1d445

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
- posted_at: `2026-11-09T22:39:42.5364720+00:00`

## Data

```json
{
  "end_line": 2211,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2202,
  "symbol": "IntegerField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2202,"selector":"L2202-L2211","symbol":"IntegerField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2211,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2202,
    "symbol": "IntegerField.get_prep_value"
  },
  "id": "2a4e361a-1932-4ca6-8f84-8411f0a1d445",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5364720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2202,
        "selector": "L2202-L2211",
        "symbol": "IntegerField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7406f1c8-ce61-4b49-9c36-eb7557648b9b",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
