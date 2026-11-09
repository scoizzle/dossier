# Fact 11af8b1a

Store id: 53e7e14c-4596-4ffb-86ed-a22a3e4a5179

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
- posted_at: `2026-11-09T23:44:50.0554750+00:00`

## Data

```json
{
  "end_line": 1231,
  "entity_kind": "method",
  "parent": "BooleanField",
  "start_line": 1227,
  "symbol": "BooleanField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1227,"selector":"L1227-L1231","symbol":"BooleanField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BooleanField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1231,
    "entity_kind": "method",
    "parent": "BooleanField",
    "start_line": 1227,
    "symbol": "BooleanField.get_prep_value"
  },
  "id": "53e7e14c-4596-4ffb-86ed-a22a3e4a5179",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0554750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1227,
        "selector": "L1227-L1231",
        "symbol": "BooleanField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c0a83efa-cd1b-4dd9-bb87-0ee512553805",
  "subject_name": "django/db/models/fields/__init__::BooleanField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
