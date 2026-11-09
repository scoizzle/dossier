# Fact 7e5e2432

Store id: 5a37dd44-a21e-4cf2-857b-81849457e33f

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:50.1939050+00:00`

## Data

```json
{
  "end_line": 2344,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2336,
  "symbol": "GenericIPAddressField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2336,"selector":"L2336-L2344","symbol":"GenericIPAddressField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2344,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2336,
    "symbol": "GenericIPAddressField.deconstruct"
  },
  "id": "5a37dd44-a21e-4cf2-857b-81849457e33f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1939050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2336,
        "selector": "L2336-L2344",
        "symbol": "GenericIPAddressField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f3d3213f-de7b-45be-8e65-24f771333833",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
