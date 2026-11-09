# Fact 6d33b0cf

Store id: 3b63d3ba-f254-4c08-bdfc-8312d3ffa583

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
- posted_at: `2026-11-09T22:39:42.5866950+00:00`

## Data

```json
{
  "end_line": 2375,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2366,
  "symbol": "GenericIPAddressField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2366,"selector":"L2366-L2375","symbol":"GenericIPAddressField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2375,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2366,
    "symbol": "GenericIPAddressField.get_prep_value"
  },
  "id": "3b63d3ba-f254-4c08-bdfc-8312d3ffa583",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5866950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2366,
        "selector": "L2366-L2375",
        "symbol": "GenericIPAddressField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5b6bbbc2-4571-47cd-aadf-8a4fc08fba93",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
