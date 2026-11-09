# Fact caf836e6

Store id: e6dc3690-b87d-4a11-b1f0-7867eab79c5c

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
- posted_at: `2026-11-09T23:44:50.2448510+00:00`

## Data

```json
{
  "end_line": 2575,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2573,
  "symbol": "TextField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2573,"selector":"L2573-L2575","symbol":"TextField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2575,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2573,
    "symbol": "TextField.get_prep_value"
  },
  "id": "e6dc3690-b87d-4a11-b1f0-7867eab79c5c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2448510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2573,
        "selector": "L2573-L2575",
        "symbol": "TextField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ff653c24-cd0d-492d-a8d8-06e87a59f329",
  "subject_name": "django/db/models/fields/__init__::TextField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
