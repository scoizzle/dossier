# Fact 647c7408

Store id: 05be36a4-7438-4e50-8654-598a95a25b0d

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
- posted_at: `2026-11-09T23:31:56.5153650+00:00`

## Data

```json
{
  "end_line": 1034,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1030,
  "symbol": "Field.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1030,"selector":"L1030-L1034","symbol":"Field.get_prep_value"}`

## Items

```json
[
  {
    "text": "Perform preliminary non-db specific value checks and conversions.",
    "locator": {
      "line": 1031
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1034,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1030,
    "symbol": "Field.get_prep_value"
  },
  "id": "05be36a4-7438-4e50-8654-598a95a25b0d",
  "items": [
    {
      "locator": {
        "line": 1031
      },
      "text": "Perform preliminary non-db specific value checks and conversions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5153650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1030,
        "selector": "L1030-L1034",
        "symbol": "Field.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b2668e83-6188-4513-b4ab-bd5f72ac84b4",
  "subject_name": "django/db/models/fields/__init__::Field.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
